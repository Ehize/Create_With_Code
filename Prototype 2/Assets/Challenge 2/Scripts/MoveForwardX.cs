using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardX : MonoBehaviour
{
    public float speed;

    // Makes the dog move forward
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
