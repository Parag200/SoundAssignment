using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{

    public CharacterController controller;
    public float speed = 12f;
    public float jumpHeight = 1.5f;

    Vector3 velo;

    public float gravity = -11.8f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    bool isGrounded;

   
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velo.y < 0)
        {
            velo.y = -2f;
        }

        

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velo.y += gravity * Time.deltaTime;

        controller.Move(velo * Time.deltaTime);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velo.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        

        
       
    }
}
