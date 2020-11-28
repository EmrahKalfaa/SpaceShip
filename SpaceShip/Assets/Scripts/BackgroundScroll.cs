using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    
    public float BackgroundSpeed = 0.1f; //Arka planin asagi kayma hizi

    Renderer rend;


    // Start is called before the first frame update
    void Start()
    {
        //rend degiskenini alma
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //Background speed skora bagli olarak degisebilir.
        float offset = Time.time * BackgroundSpeed;

        //her frame de kaydirma islemini yapiyoruz.
        rend.material.mainTextureOffset = new Vector2(0, offset);
        

    }

   
}
