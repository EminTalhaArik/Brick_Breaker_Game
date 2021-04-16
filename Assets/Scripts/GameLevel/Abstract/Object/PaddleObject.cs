using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleObject : MonoBehaviour
{
    [Header("Paddle Object")]
    [SerializeField] private float PaddleSpeed;

    [Tooltip("Screen Edges")]
    [SerializeField] private float LeftScreenEdge;
    [SerializeField] private float RightScreenEdge;

    public void PaddleMove()
    {
        float horizontal = Input.GetAxis("Horizontal");

        transform.Translate(Vector2.right * horizontal * Time.fixedDeltaTime * PaddleSpeed);

        if (transform.position.x < LeftScreenEdge)
        {
            transform.position = new Vector2(LeftScreenEdge, transform.position.y);
        }

        if (transform.position.x > RightScreenEdge)
        {
            transform.position = new Vector2(RightScreenEdge, transform.position.y);
        }
    }
}
