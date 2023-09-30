using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookieRotation : MonoBehaviour
{
    public float rotationSpeed = 180f;

    private void FixedUpdate()
    {
        transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
    }
}
