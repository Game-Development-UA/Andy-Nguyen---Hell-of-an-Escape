using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{

    public Rigidbody2D player;
    public float playerSpeed;
    public float jumpPower;
    ///private int health = 1;
    float horizontal;
    bool grounded;

    void Start()
    {
        grounded = false;
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        player.velocity = new Vector2(horizontal * playerSpeed, player.velocity.y);

        if (Input.GetKeyDown(KeyCode.UpArrow) && grounded)
        {
            player.AddForce(new Vector2(0f, jumpPower), ForceMode2D.Impulse);
            grounded = false;
        }

        if (horizontal < 0)
        {
            transform.right = new Vector3(-1f, 0f, 0f);
        }
        else if (horizontal > 0)
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