using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }

        if(collision.collider.tag == "Eat")
        {
            Destroy(collision.gameObject);
            Time.timeScale = 0;
        }
    }

    
}
