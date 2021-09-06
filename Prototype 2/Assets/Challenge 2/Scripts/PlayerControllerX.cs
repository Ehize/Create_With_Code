using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
	public float firstStrike = 1;
	public float secondStrike = 0;

    // Update is called once per frame
    void Update()
    {
        // Allows the player to spawn a new dog after a certain amount of time has passed
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > secondStrike)
        {
			secondStrike = Time.time + firstStrike;
			
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
