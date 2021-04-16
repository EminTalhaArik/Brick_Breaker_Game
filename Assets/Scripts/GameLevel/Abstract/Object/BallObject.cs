using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallObject : Object
{
    [Header("Ball Object")]
    [SerializeField] private int BallDamage;
    [SerializeField] private float BallStartSpeed;

    [Header("Ball Object Component")]
    [SerializeField] private Rigidbody2D myRigidbody;

    [Header("Sound")]
    [SerializeField] private AudioSource myAudioSource;
    [SerializeField] private AudioClip HitSound;

    [HideInInspector] public bool IsPlay;

    private void Start()
    {
        InitializeVariable();
        StartBall();
    }

    private void InitializeVariable()
    {
        myAudioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Brick")
        {
            collision.gameObject.GetComponent<BrickObject>().TakeDamage(BallDamage);
            PlayHitSound();
            GameObject.Find("GameManager").GetComponent<GameManager>().ControlBricks();
        }
        GameObject.Find("GameManager").GetComponent<GameManager>().ControlBricks();
    }

    public void ForceToBall(float BallForce)
    {
        myRigidbody.AddForce(transform.up * BallForce);
    }

    public void StopBall()
    {
        IsPlay = false;
        myRigidbody.velocity = Vector2.zero;
    }

    public void StartBall()
    {
        IsPlay = true;
        ForceToBall(BallStartSpeed);
    }

    public override void HealthControl()
    {
        if (ObjectHealth <= 0)
        {
            Debug.Log(ObjectName + " is destroyed");
            GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().EndGame();
            Destroy(this.gameObject);
        }
    }

    public void PlayHitSound()
    {
        myAudioSource.PlayOneShot(HitSound);
    }
}
