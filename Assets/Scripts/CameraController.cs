using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Car _car; 
    [SerializeField] private Vector3 _offset; 

    void Start()
    {
        _car = FindObjectOfType<Car>();
    }

    void LateUpdate()
    {
        transform.position = _car.transform.position + _offset;
    }
}