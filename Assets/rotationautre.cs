using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class rotationautre : MonoBehaviour

{

    [SerializeField] private Vector3 axeRotation;
  
    [SerializeField] private float vitesse;  

    // Update is called once per frame
    
          void Start()
    {
        vitesse = Random.Range(2.0f, 4.0f);
    }

    // Update is called once per frame
    
        void Update()
    {
        
        transform.Rotate(axeRotation*vitesse*Time.deltaTime);
    }
}