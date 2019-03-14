using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;


public class Player_Controller : MonoBehaviour
{

    public Rigidbody2D player;
    public float playerSpeed;
    public float jumpPower;
    private float xInput;
    bool grounded;
    public float runThreshold;
    public float jumpThreshold;
    public Animator Animation;

    void Start()
    {

    }

    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
            Animation.SetBool("Jump", true);
        }

        player.velocity = new Vector2(xInput * playerSpeed, player.velocity.y);

        Animation.SetBool("Move", Mathf.Abs(player.velocity.x) > runThreshold);

        if (xInput > 0f)
        {
            player.transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }

        if (xInput < 0f)
        {
            player.transform.eulerAngles = new Vector3(0f, 180f, 0f);
        }
        if (player.velocity.y < -jumpThreshold)
        {
            Animation.SetBool("Jump", false);
        }
    }

    void FixedUpdate()
    {
        player.velocity = new Vector2(xInput * playerSpeed, player.velocity.y);
    }

    void Jump()
    {
        player.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
    }
 
}