using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrail : MonoBehaviour
{
    public float startTimeBtwSpawn;
    float timeBtwSpawn;
    public GameObject trailPrefab;

    private void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            GameObject tail = Instantiate(trailPrefab, transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
            Destroy(tail, 2f);
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
