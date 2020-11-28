using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    #region defines

    Ship1 learp;

    Ship2 learp2;

    #endregion

    #region methotds
    // Start is called before the first frame update
    void Start()
    {
        //object can acsess Lear script
        learp = Object.FindObjectOfType<Ship1>();
        learp2 = Object.FindObjectOfType<Ship2>();
    }

    //when ship trigger point where it stop
    //j value in Learp script equal to 3
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "ship")
        {



            //this is using by Learp for check rotation should be reset 
            learp.j = 3;

            Debug.Log("true");



        }

        if (collision.gameObject.tag == "ship2")
        {



            //this is using by Learp for check rotation should be reset 
            learp2.j = 3;




        }


    }
}
#endregion