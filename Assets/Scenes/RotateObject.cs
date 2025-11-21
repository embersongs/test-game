using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 100f; // скорость поворота в градусах в секунду

    void Update()
    {
        if (Input.GetKey(KeyCode.O))
        {
            // Вращение влево
            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.P))
        {
            // Вращение вправо
            transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
        }
    }
}