using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    //Detroy's the ball and dog on impact
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
		Destroy(other.gameObject);
    }
}
