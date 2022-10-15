using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
	[SerializeField] float jumpPower;

    public Transform groundCheck;
    public LayerMask groundLayer;
    bool readyToJump;

	Rigidbody2D rb;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
        readyToJump = Physics2D.OverlapCapsule(groundCheck.position, new Vector2(4.92f, 0.3f), CapsuleDirection2D.Horizontal, 0, groundLayer);

        Inputs();
	}

    void Inputs()
    {
        if(Input.GetButtonDown("Jump") && readyToJump)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        }
        if(Input.GetKeyDown(KeyCode.C))
        {
            rb.velocity = new Vector2(rb.velocity.x, -jumpPower);
            rb.AddForce(Vector2.down);
        }
    }

}
