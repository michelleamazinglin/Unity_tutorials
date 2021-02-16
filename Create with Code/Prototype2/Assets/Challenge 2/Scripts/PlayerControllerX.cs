using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    public float spawnInterval = 0.5f;
    public bool canSpawn = true;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (canSpawn && Input.GetKeyDown(KeyCode.Space))
        {
            canSpawn = false;
            Invoke(nameof(CanSpawnDog), spawnInterval);
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }

    private void CanSpawnDog()
    {
        canSpawn = true;
    }
}