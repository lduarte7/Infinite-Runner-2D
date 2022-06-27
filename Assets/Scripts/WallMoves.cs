using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMoves : MonoBehaviour
{
    public float wallSpeed;

    private void Update()
    {
        transform.position += Vector3.left * wallSpeed * Time.deltaTime;


    }
}
