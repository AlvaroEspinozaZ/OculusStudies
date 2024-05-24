using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputOculus : MonoBehaviour
{
    public float speed = 5.0f;
    public Transform cameraTransform;
    public bool moveInY = false;

    void Update()
    {
        Vector3 moveDirection = cameraTransform.forward;

        if (!moveInY)
        {
            moveDirection.y = 0;
        }

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = (moveDirection * verticalInput + cameraTransform.right * horizontalInput) * speed * Time.deltaTime;

        transform.Translate(movement);
    }
}
