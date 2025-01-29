using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class mouvementPoutre : MonoBehaviour
{


   
    [SerializeField] private Vector3 axeRotation;
    [SerializeField] public float vitesse;  

    void Start()
    {
        vitesse = Random.Range(2.0f, 4.0f);
       
    }

    void Update()
    {
        float angle = vitesse * Time.deltaTime;
        transform.Rotate(axeRotation, angle);
        
            
             
        

    }
}





