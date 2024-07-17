using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
public class CameraController: MonoBehaviour
{

    [Header("Rotational Speeds")]

    public float verticalRotationSpeed;

    public float horizontalRotationSpeed;

    [Header("Object Transforms")]
    [SerializeField, Tooltip("Which transform is rotated along x axis")]
    private Transform _rotatedXTransform;
    [SerializeField] private Transform _rotatedYTransform;

    void Update(){
        float mouseInputX = Input.GetAxis("Mouse X");

        float mouseInputY = Input.GetAxis("Mouse Y");

        _rotatedXTransform.Rotate(0,
                                    horizontalRotationSpeed * mouseInputX * Time.deltaTime,
                                0);
        _rotatedYTransform.Rotate(0,
                                    verticalRotationSpeed * mouseInputY * Time.deltaTime,
                                0);
    }
}