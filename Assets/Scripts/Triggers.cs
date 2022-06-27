using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggers : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Soma a pontuação
        if (collision.gameObject.tag == "Coin")
        {
            GameManager.Instace.AddScore();
            Destroy(collision.gameObject, 0.02f);
        }

        // Destroi o player
        if (collision.gameObject.tag == "Wall")
        {
            GameManager.Instace.GameOver();
            Destroy(gameObject, 0.02f);
        }
    }

}
