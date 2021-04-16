using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickObject : Object
{
    [Header("Brick Object")]
    [SerializeField] private GameObject ExplosionEffect;

    public override void HealthControl()
    {
        if (ObjectHealth <= 0)
        {
            Debug.Log(ObjectName + " is destroyed");
            CreateEffects();
            Destroy(this.gameObject);
        }
    }

    public void CreateEffects()
    {
        GameObject spawnEffect = Instantiate(ExplosionEffect, transform.position, Quaternion.identity);
    }
}
