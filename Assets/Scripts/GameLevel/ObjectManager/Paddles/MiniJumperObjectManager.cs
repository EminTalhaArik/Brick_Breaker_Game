using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniJumperObjectManager : MonoBehaviour
{
    public bool isFight = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball") && isFight)
        {
            collision.gameObject.GetComponent<BallObject>().SetBallSpeed(Random.Range(20, 70));
        }
    }
}
