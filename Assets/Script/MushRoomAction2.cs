using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushRoomAction2 : MonoBehaviour {
    public int maxSpeed = 1;
    public float speed = 10f;
    public float jumpForce = 50f;
    public float h;
    public bool grounded;
    const string HORISONTAL = "Horizontal";
    public Rigidbody2D mushRoomRigid2D;
    public Animator animator;


	// Use this for initialization
	void Start () {
        mushRoomRigid2D = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        animator.SetBool("Grounded", grounded);
        //animator.SetFloat("Speed", Mathf.Abs(Input.GetAxis(HORISONTAL)));

        if (Input.GetAxis(HORISONTAL) < -0.1f)
        {
            transform.localScale = new Vector3(-1, 1, 1);

        }
        if (Input.GetAxis(HORISONTAL) > 0.1f)
        {
            transform.localScale = new Vector3(1, 1, 1);

        }
        if (Input.GetButtonDown("Jump") && grounded)
        {
            mushRoomRigid2D.AddForce(Vector2.up * jumpForce);
        }
    }

    void FixedUpdate()
    {
       h = Input.GetAxis(HORISONTAL);

        //move the character
        mushRoomRigid2D.AddForce((Vector2.right * speed) * h);

        //limit the speed of character
        if (mushRoomRigid2D.velocity.x > maxSpeed)
        {
            mushRoomRigid2D.velocity = new Vector2(maxSpeed, mushRoomRigid2D.velocity.y);
        }
        if (mushRoomRigid2D.velocity.x < -maxSpeed)
        {
            mushRoomRigid2D.velocity = new Vector2(-maxSpeed, mushRoomRigid2D.velocity.y);
        }
    }
}
