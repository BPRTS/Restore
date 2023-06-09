using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player_Movement : MonoBehaviour
{
    public CharacterController controller;
    public Transform groundCheck;
    public Player playerInput;
    public PopUpWindow popUpWindow;

    public InventoryTabs inventoryTabs;


    public float speed = 12f;
    [SerializeField]
    public float gravity = -9.81f;
    [SerializeField]
    public float jumpHeight = 3f;
    [SerializeField]

    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    public bool isBreathing = false;
    public Slider oxygenBar;

    private Animator playerAnimator;
    public Transform playerModel;
    private Quaternion targetRotation;

//    public WarningManager warningManager;

    public void Awake()
    {
        playerInput = new Player();
        controller = GetComponent<CharacterController>();
        playerAnimator = this.GetComponentInChildren<Animator>();
    }
    public void OnEnable()
    {
        playerInput.Enable();
    }
    public void OnDisable()
    {
        playerInput.Disable();
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
            inventoryTabs.HideAllTabs();
            targetRotation = Quaternion.LookRotation(move) ;
            targetRotation *= Quaternion.Euler(0f, 180f, 0f);
            playerModel.rotation = Quaternion.Lerp(playerModel.rotation, targetRotation, Time.deltaTime * 2);
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
            oxygenBar.value -= 0.001f;
        }
        if(isBreathing)
        {
            oxygenBar.value += 0.015f;
        }

        
       //if (oxygenBar.value == 0.999f && isBreathing == false)
        // {s
        //    popUpWindow.AddToQueue("You are leaving the oxygen zone. Be careful.");
       //}

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
