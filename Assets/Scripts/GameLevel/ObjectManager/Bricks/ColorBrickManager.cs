using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorBrickManager : BrickObject
{
    public override void HealthControl()
    {
        ChangeColor();
        if (ObjectHealth <= 0)
        {
            Debug.Log(ObjectName + " is destroyed");
            CreateEffects();
            Destroy(this.gameObject);
        }
    }

    public void ChangeColor()
    {
        if (ObjectHealth >= 2)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        }
    }
}
