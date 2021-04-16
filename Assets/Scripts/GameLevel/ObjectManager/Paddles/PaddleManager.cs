using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleManager : PaddleObject
{
    private void FixedUpdate()
    {
        PaddleMove();
    }
}
