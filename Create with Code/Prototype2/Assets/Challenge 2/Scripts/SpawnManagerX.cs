using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;
    private int ball;

    private float startDelay = 1.0f;
    private float spawnInterval = 1.0f;

    private float interval = 1.0f;
    private float counter = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("randomInterval", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        ball = Random.Range(0, ballPrefabs.Length);
        Instantiate(ballPrefabs[ball], spawnPos, ballPrefabs[ball].transform.rotation);
    }

    void randomInterval(){
        if(interval >= counter){
            SpawnRandomBall();
            counter = Random.Range(3,5);
        }else{
            interval++;
        }
    }

}
