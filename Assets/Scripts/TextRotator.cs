using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextRotator : MonoBehaviour
{
    [SerializeField] float xRotationSpeed;
    [SerializeField] float yRotationSpeed;
    [SerializeField] float zRotationSpeed;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(new Vector3(xRotationSpeed, yRotationSpeed, zRotationSpeed));
    }
}
