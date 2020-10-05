using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController control;
    Animator anim;

    public float moveSpeed;
    public float jumpForce;

    public float gravityScale;
    public Vector3 moveDirection;
    void Start()
    {
        anim = GetComponent<Animator>();
        control = GetComponent<CharacterController>();
    }
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        float y = moveDirection.y;

        moveDirection = (transform.forward * z) + (transform.right * x);

        moveDirection = moveDirection.normalized * moveSpeed;

        moveDirection.y = y;

        if (control.isGrounded)
        {
            moveDirection.y = 0;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                moveDirection.y = jumpForce;
            }
        }
        moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityScale * Time.deltaTime);
        anim.SetBool("isGrounded", control.isGrounded);
        anim.SetFloat("speed", Mathf.Abs(z) + Mathf.Abs(x));
    }
}
