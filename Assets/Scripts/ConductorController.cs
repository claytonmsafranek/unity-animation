using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConductorController : MonoBehaviour
{

    public float jumpForce;
    [SerializeField] private float speed = 1;

    private Animator anim;
    private Rigidbody2D rb;
    private Vector2 movementDirection;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // get move input
        float moveInput = Input.GetAxisRaw("Horizontal");

        if (moveInput == 0)
        {
            // conductor not moving, play idle animation
            anim.SetBool("isRunning", false);
        }
        else
        {
            // conductor is moving, play run animation and move transform
            anim.SetBool("isRunning", true);
        }

        // move player
        if (Input.GetKeyDown(KeyCode.D))
        {
            gameObject.transform.position += Vector3.forward;
        }


    }
}
