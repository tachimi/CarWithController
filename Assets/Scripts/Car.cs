using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Car : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        var position = gameObject.transform.position;
        var step = _speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
        {
            position.z += step;
        }

        if (Input.GetKey(KeyCode.S))
        {
            position.z -= step;
        }

        if (Input.GetKey(KeyCode.A))
        {
            position.x -= step / 2;
        }

        if (Input.GetKey(KeyCode.D))
        {
            position.x += step / 2;
        }

        transform.position = position;
    }
}