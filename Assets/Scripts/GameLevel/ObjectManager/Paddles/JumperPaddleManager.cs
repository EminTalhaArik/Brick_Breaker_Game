using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumperPaddleManager : PaddleObject
{
    [Header("Jumper Paddle Manager")]
    [SerializeField] private Animator myAnimator;
    private float JumpTime = 0;
    [SerializeField] private MiniJumperObjectManager jumperObject;

    private void Update()
    {
        if (Input.GetAxis("Jump") > 0 && JumpTime <= Time.time)
        {
            Debug.Log("Jump Tuþuna Basýldý!");
            Jump();
            JumpTime = Time.time + 0.4f;
        }
    }

    private void FixedUpdate()
    {
        PaddleMove();
    }

    public void Jump()
    {
        myAnimator.SetTrigger("Jump");
    }

    public void PunchOkey()
    {
        jumperObject.isFight = true;
    }

    public void PunchDont()
    {
        jumperObject.isFight = false;
    }
}
