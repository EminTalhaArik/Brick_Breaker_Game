using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class StandartBallManager : BallObject
{
    [SerializeField] private Transform ballPaddlePosition;

    private void Start()
    {
        IsPlay = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bottom"))
        {
            Debug.Log("Ball git the bottom of the screen");
            TakeDamage(1);
            IsPlay = false;
            StopBall();
        }
    }

    private void Update()
    {
        if (!IsPlay)
        {
            transform.position = ballPaddlePosition.transform.position;
        }

        if (Input.GetButtonDown("Jump") && !IsPlay)
        {
            StartBall();
        }
    }
}
