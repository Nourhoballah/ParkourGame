using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class mouvementArbre : MonoBehaviour
{

    public GameObject platform;
    public float vitesse;

    private Vector3 direction;
    private float limite;


    // Start is called before the first frame update
    void Start()
    {
      
        direction = new Vector3(0, 1, 0);
        vitesse = Random.Range(2.0f, 4.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * vitesse * Time.deltaTime;

        if (transform.position.y >= limite || transform.position.y <= -limite)
        {
            direction = -direction;
        }
    }


}



