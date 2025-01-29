using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UIElements;

public class arbrepratique : MonoBehaviour
{
    
    public float vitesse;
    public float limite = 4.0f;  
    private Vector3 direction;



    private bool bouger = true;  
    private float débutpause;  
    private float pause;








    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector3(0, 1, 0);  
        vitesse = Random.Range(2.0f, 4.0f);
        Debug.Assert(vitesse != 0, "La vitesse ne devrait pas être nulle");//je voulais vérifier quelquechose
    }


    void Update()
    {
        if (bouger)
        {
            transform.position += direction * vitesse * Time.deltaTime;

            
            if (transform.position.y > limite)
            {
                transform.position = new Vector3(transform.position.x, limite, transform.position.z);
                direction = new Vector3(0, -1, 0);  
            }
           
            else if (transform.position.y < -limite)
            {
                transform.position = new Vector3(transform.position.x, -limite, transform.position.z);
                bouger = false;  
                débutpause = Time.time;  
                pause = Random.Range(1.0f, 2.0f); 
            }
        }
        else
        {
            if (Time.time - débutpause >= pause)
            {
                bouger = true;  
                direction = new Vector3(0, 1, 0);  
            }
        }
    }





}





