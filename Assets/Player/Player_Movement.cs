using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public CharacterController controller;
    public Transform groundCheck;
    public Player playerInput;


    public float speed = 12f;
    [SerializeField]
    public float gravity = -9.81f;
    [SerializeField]
    public float jumpHeight = 3f;
    [SerializeField]

    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    public void Awake()
    {
        playerInput = new Player();
        controller = GetComponent<CharacterController>();
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
        Vector3 move = new Vector3(movementInput.x, 0f, movementInput.y);

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
    }
}
