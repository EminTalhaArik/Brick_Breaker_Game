using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Object : MonoBehaviour
{
    [Header("Object")]
    public int ObjectHealth;
    public string ObjectName;

    public abstract void HealthControl();

    public void TakeDamage(int DamageCount)
    {
        ObjectHealth -= DamageCount;
        HealthControl();
    }
}
