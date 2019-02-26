using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{

    public Rigidbody2D player;
    public float playerSpeed;
    public float jumpPower;
    ///private int health = 1;
    private float xInput;
    bool grounded;
    public float runThreshold;

    void Start()
    {
        grounded = false;
    }

    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        player.velocity = new Vector2(xInput * playerSpeed, player.velocity.y);

        ///Animator.SetBool("Running", Mathf.Abs(player.velocity.x) > runThreshold);

        if( player.velocity.x > runThreshold )
        {
            player.transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        
        if( player.velocity.x < runThreshold )
        {
            player.transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && grounded)
        {
            player.AddForce(new Vector2(0f, jumpPower), ForceMode2D.Impulse);
            grounded = false;
        }

        if (xInput < 0)
        {
            transform.right = new Vector3(-1f, 0f, 0f);
        }
        else if (xInput > 0)
        {
            transform.right = new Vector3(1f, 0f, 0f);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("GroundFloorTile") && grounded == false)
        {
            grounded = true;
        }
    }
}