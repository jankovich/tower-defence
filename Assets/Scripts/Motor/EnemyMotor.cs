using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMotor : BaseMotor
{
    protected override void UpdateMotor()
    {
        MoveVector = Direction();

    }

    public Vector3 Direction()
    {
        return Vector3.zero;
    }
}
