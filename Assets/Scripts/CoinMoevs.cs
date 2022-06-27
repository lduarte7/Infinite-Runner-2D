using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMoevs : MonoBehaviour
{
    public float coinSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * coinSpeed * Time.deltaTime;
    }
}
