using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    public float rotationSpeed = 50f;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            RotateCounterClockObjectAroundZAxis();
        }

        if (Input.GetKey(KeyCode.S))
        {
            RotateClockwiseObjectAroundZAxis();
        }
    }

    private void RotateCounterClockObjectAroundZAxis()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
    private void RotateClockwiseObjectAroundZAxis()
    {
        transform.Rotate(Vector3.forward * -rotationSpeed * Time.deltaTime);
    }
}
