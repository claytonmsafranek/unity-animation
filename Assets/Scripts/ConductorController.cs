using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConductorController : MonoBehaviour
{

    public float jumpForce;
    [SerializeField] private float speed = 2f;

    private Animator anim;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // get move input
        // float moveInput = Input.GetAxisRaw("Horizontal");
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
/*
        if (inputX == 0)
        {
            // conductor not moving, play idle animation
            anim.SetBool("isRunning", false);
        }
        else
        {
            // conductor is moving, play run animation and move transform
            anim.SetBool("isRunning", true);
        }*/

        // move player
        if (Input.GetKey(KeyCode.D))
        {
            // anim.SetBool("isRunning", true);
            Debug.Log("trying to run right");
            transform.position += Vector3.right * speed * Time.deltaTime;
            Debug.Log("position: " + transform.position);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("trying to run left");
            Debug.Log("position: " + transform.position);
            transform.position += Vector3.right * -speed * Time.deltaTime;
        }
        else
        {
            // player not running, go back to idle
            anim.SetBool("isRunning", false);
        }


    }

}
