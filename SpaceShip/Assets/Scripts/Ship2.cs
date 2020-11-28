using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship2 : MonoBehaviour
{
    #region defines

    [SerializeField]
    GameObject ship;

    [SerializeField]
    Transform endPoint;

    [SerializeField]
    Transform startPoint;

    [SerializeField]
    public int i = 0;

    [SerializeField]
    public int j = 0;

    [SerializeField]
    public float speed;

    [SerializeField]
    bool isMove = true;

    [SerializeField]
    bool isRotate = true;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        //lerp komutu icin 
        speed = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {


        //hangi yöne gideceğine karar veriyoruz
        if (i == 1)
        {

            //eğer gideceği yer vardıysa gemi yönünü düzeltiyorum
            //eğer varmadıysa lerp işlemi devam ediyot
            if (j == 3)
            {
                ship.transform.position = Vector3.MoveTowards(ship.transform.position, endPoint.position, speed);
                ship.transform.rotation = Quaternion.Lerp(ship.transform.rotation, Quaternion.Euler(0, 0, 0), speed);




            }
            else
            {
                ship.transform.position = Vector3.MoveTowards(ship.transform.position, endPoint.position, speed);
                ship.transform.rotation = Quaternion.Lerp(ship.transform.rotation, Quaternion.Euler(0, 0, -90), speed);

            }




        }

        //hangi yöne gideceğine karar veriyoruz
        if (i == 2)
        {
            //eğer gideceği yer vardıysa gemi yönünü düzeltiyorum
            //eğer varmadıysa lerp işlemi devam ediyot
            if (j == 3)
            {
                ship.transform.position = Vector3.MoveTowards(ship.transform.position, startPoint.position, speed);

                ship.transform.rotation = Quaternion.Lerp(ship.transform.rotation, Quaternion.Euler(0, 0, 0), speed);

            }
            else
            {
                ship.transform.position = Vector3.MoveTowards(ship.transform.position, startPoint.position, speed);
                ship.transform.rotation = Quaternion.Lerp(ship.transform.rotation, Quaternion.Euler(0, 0, 90), speed);

            }


        }




    }

    //i hangi yöne gieceğini kontrol ediyor
    //j lerp tamamlandığında geminin düzelmesini kontrol ediyor
    //isMove da tek butonda çalışmamızı sağlıyor
    public void Move()
    {
        if (isMove == true)
        {

            i = 1;
            j = 0;
            isMove = false;


        }

        else if (isMove == false)
        {

            i = 2;
            j = 0;
            isMove = true;

        }


    }
}
