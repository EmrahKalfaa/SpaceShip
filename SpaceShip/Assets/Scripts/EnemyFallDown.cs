using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFallDown : MonoBehaviour
{
    //Skora bagli olarak artacak hiz
    private float EnemySpeed = 5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * EnemySpeed * Time.deltaTime);
    }
}
