using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushRoomAction : MonoBehaviour {
    /*
    public bool canMove;
    public int isFinish;
    public Animator animator;
    public AnimationEvent animationEvent;
    public Rigidbody2D mushRoomRigidbody2D;
    public int actionT = 0;
    
    public float horizontalDirection = 1;
    const string HORIZONTAL = "Horizontal";
    
    public float speedX;
    
    public float xForce=1;

    public float yForce;
    public float speedY;

    public float maxSpeedX;

    System.Random random;
    
    void MovementX(bool cm)
    {
        //mushRoomRigidbody2D.AddForce(new Vector2(xForce * horizontalDirection, 0));
        if (canMove == true)
        {
            transform.Translate(xForce * horizontalDirection * Time.deltaTime, 0, 0);
        }
    }

    void ControlSpeed()
    {
        speedX = mushRoomRigidbody2D.velocity.x;
        speedY = mushRoomRigidbody2D.velocity.y;
        float newSpeedX = Mathf.Clamp(speedX, -maxSpeedX, maxSpeedX);
        mushRoomRigidbody2D.velocity = new Vector2(newSpeedX, speedY);
    }

    // Use this for initialization
    void Start () {
        isFinish = 0;
        animator = GetComponent<Animator>();
        mushRoomRigidbody2D = GetComponent<Rigidbody2D>();
        random = new System.Random(1000);
    }

    // Update is called once per frame
    void Update () {
        MovementX(canMove);
    }
    
    public void IdleFinishRight(int isFinish)
    {
        if (isFinish == 1)
        {
            animator.SetBool("isIdleRight", false);
            animator.SetBool("isJumpRight", true);
        }
    }
    
    public void JumpFinishRight(int isFinish)
    {
        if (isFinish == 1)
        {
            if (actionT == 0)
            {
                horizontalDirection = -1;
            }
            else
            {
                horizontalDirection = 1;
                actionT = 0;
            }

            animator.SetBool("isIdleRight", true);
            animator.SetBool("isJumpRight", false);
            actionT = actionT+1;
            canMove = false;
        }
        else
        {
            canMove = true;
        }
    }

    public void WalkFinishRight(int isFinish)
    {
        if (isFinish == 1)
        {
            animator.SetBool("isIdleRight", true);
            animator.SetBool("isWalkRight", false);
        }
        
    }

    public int RandomRange(int min, int max)
    {
        return random.Next(min, max);
    }
    */
}
