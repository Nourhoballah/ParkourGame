using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class MouvementDesTrains : MonoBehaviour
{

    public GameObject planGare;
    public float vitesse;

    private Vector3 direction;
    private float limite= 17.47f;


    // Start is called before the first frame update
    void Start()
    {
       
            direction = new Vector3(1, 0, 0);
        vitesse = Random.Range(2.0f, 4.0f);
    }

    // Update is called once per frame
    void Update()
    
    {
            transform.position += direction * vitesse * Time.deltaTime;

            
            if (transform.position.x > limite)
            {
                transform.position = new Vector3(limite, transform.position.y, transform.position.z); 
                direction = new Vector3(-1, 0, 0); 
            }
            else if (transform.position.x < -limite)
            {
                transform.position = new Vector3(-limite, transform.position.y, transform.position.z); 
                direction = new Vector3(1, 0, 0); 
            }
    }
       // transform.position += direction * vitesse * Time.deltaTime;

      

       //if (transform.position.x >= limite || transform.position.x <= -limite)
           
        //{
           
         //   direction = -direction;
        //}


       
    
}








