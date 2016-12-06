using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseMotor : MonoBehaviour
{
    protected CharacterController motorController;
    protected Transform motorTransform;

    private float baseSpeed = 5.0f;

    public float Speed { get { return baseSpeed; } }
    public Vector3 MoveVector { set; get; }

    protected abstract void UpdateMotor();

    protected virtual void Start()
    {
        motorController = gameObject.AddComponent<CharacterController>();
        motorTransform = transform;
    }

    private void Update()
    {
        UpdateMotor();
    }
}
