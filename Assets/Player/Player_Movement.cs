using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using FMODUnity;
using FMOD.Studio;

public class Player_Movement : MonoBehaviour
{
    public CharacterController controller;
    public Transform groundCheck;
    public Player playerInput;
    public PopUpWindow popUpWindow;

    public InventoryTabs inventoryTabs;
    public TutorialSequence tutorialSequence;

    private bool breathingWarning = false;

    public float speed = 12f;
    [SerializeField]
    public float gravity = -9.81f;
    [SerializeField]
    public float jumpHeight = 3f;
    [SerializeField]

    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    public bool isBreathing = true;
    public Slider oxygenBar;

    private Animator playerAnimator;
    public Transform playerModel;
    private Quaternion targetRotation;

    public GameObject burgerbutton;

    //walking sound FMOD
    private FMOD.Studio.EventInstance instance;


    //    public WarningManager warningManager;

    public void Awake()
    {
        playerInput = new Player();
        controller = GetComponent<CharacterController>();
        playerAnimator = this.GetComponentInChildren<Animator>();

        if (PlayerPrefs.GetString("ButtonSide") == "Right")
        {
            Debug.Log("Right");
            burgerbutton.transform.localPosition = new Vector3(390f, -901f, 0f);
        }
        else if (PlayerPrefs.GetString("ButtonSide") == "Left")
        {
            Debug.Log("Left");
            burgerbutton.transform.localPosition = new Vector3(-337f, -901f, 0f);
        }
    }
    public void OnEnable()
    {
        playerInput.Enable();
    }
    public void OnDisable()
    {
        playerInput.Disable();
    }

    void Start()
    {
        instance = FMODUnity.RuntimeManager.CreateInstance("event:/WalkingGrass");
    }


    Vector3 velocity;
    bool isGrounded;

    // Update is called once per frame
    void Update()
    {

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }


        Vector2 movementInput = playerInput.Movement.Move.ReadValue<Vector2>();
        bool isWalking = (movementInput.x != 0f || movementInput.y != 0f);
        Vector3 move = new Vector3(movementInput.x, 0f, movementInput.y);
        if (isWalking)
        {
            if(tutorialSequence.stage == 0)
            {
                tutorialSequence.stage = 1;
            }

            tutorialSequence.stage = 1;
            inventoryTabs.HideAllTabs();
            targetRotation = Quaternion.LookRotation(move) ;
            targetRotation *= Quaternion.Euler(0f, 180f, 0f);
            playerModel.rotation = Quaternion.Lerp(playerModel.rotation, targetRotation, Time.deltaTime * 2);
        }
        else
        {
            instance.start();
        }
        playerAnimator.SetBool("Walking", isWalking);
        


        controller.Move(move * speed * Time.deltaTime);

       // if(Input.GetButtonDown("Jump")&& isGrounded)

       // {
 //           velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
   //     }    
     velocity.y += gravity * Time.deltaTime;

       controller.Move(velocity * Time.deltaTime);

      //  if(groundCheck.transform.position.y < -10)
        //{
        //    controller.transform.position = new Vector3(17.31f, 12.58f, 40.94f);
        //}

        if(!isBreathing)
        {
            oxygenBar.gameObject.SetActive(true);
            oxygenBar.value -= 0.0005f;
        }
        if(isBreathing)
        {
            breathingWarning = false;
            oxygenBar.value = 100f;
            oxygenBar.gameObject.SetActive(false);
        }


        Debug.Log(isBreathing);
        Debug.Log(breathingWarning);
        Debug.Log(tutorialSequence.stage);
      if(!isBreathing && !breathingWarning && tutorialSequence.stage >=1)
        {
            popUpWindow.AddToQueue("You are leaving the Oxygen Zone! Be careful.");
            breathingWarning = true;
        }

       //if(oxygenBar.value == 0.2500097f && isBreathing == false)
        //{
         //   popUpWindow.AddToQueue("You are about to run out of oxygen. Return to the area.");
       // }
       //if(oxygenBar.value == 0.00f)
        //{
          //TODO: DIE  
        //}
    }


}
