using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlamethrowerRotateScript : MonoBehaviour
{
    public float RotationSpeed;
    public float Angle;
    public float CycleTime;

    private bool goLeft;
    private float currentCycleTime;

    private void Start()
    {
        currentCycleTime = CycleTime;
    }

    void Update()
    {
        currentCycleTime -= Time.deltaTime;
        if (currentCycleTime < 0)
        {
            goLeft = !goLeft;
            currentCycleTime = CycleTime;
        }
        
        if (goLeft)
            transform.Rotate(Vector3.up, -Angle * RotationSpeed * Time.deltaTime);
        else
            transform.Rotate(Vector3.up, Angle * RotationSpeed * Time.deltaTime);
    }
}