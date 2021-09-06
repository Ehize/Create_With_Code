using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;
    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    
    private float spawnInterval;
	private float timeInterval;
	
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }
	
	
	//Allows balls drop at random timeInterval 
	void Update()
	{
		  timeInterval += Time.deltaTime;
		
		if(timeInterval > spawnInterval)
		{
			SpawnRandomBall();
			spawnInterval = Random.Range(3.0f, 5.0f);
			timeInterval = 0;
		}
	}
	

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    { 
		int ballIndex = Random.Range(0, ballPrefabs.Length);
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }

}
