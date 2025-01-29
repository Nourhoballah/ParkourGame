
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class mouvementJoueur : MonoBehaviour
{
    public GameObject planGare;
    public float _vitesseDeplacement = 4f;

    private float limite;
    public Transform[] teleportationZones;
    private int currentZoneIndex = 0;
    public KeyCode keyToDetect = KeyCode.N;

    public float tempsGare;
    public float tempsForet;
    public float tempsChantier;

    private scriptcanva canva;
    public int PenalitéGare;
    public int PenalitéForet;
    public int PenalitéChantier;
    private int noZone = 0;


    public bool BOUGER = true;



    // Start is called before the first frame update
    void Start()
    {
        limite = planGare.transform.localScale.x * 5 - transform.localScale.x / 2;
        canva = GameObject.Find("Canvas").GetComponent<scriptcanva>();

        //canva.nomjoueur = canva.nomtotal;

    }

  

    // Update is called once per frame
    void Update()
    {

        if (BOUGER)
        { 

            //les mouvements

            float vertical = Input.GetAxis("Vertical");
            float horizontal = Input.GetAxis("Horizontal");


            Vector3 deplacement = new Vector3(horizontal, 0, vertical) * _vitesseDeplacement * Time.deltaTime;
            Vector3 nouvellePosition = transform.position + deplacement;

            
            if (nouvellePosition.x <= limite && nouvellePosition.x >= -limite && nouvellePosition.z >= -14)

            {
                transform.position = nouvellePosition;
            }

        }




        //FONCTIONNEMENT DE N ET ESC

        if (Input.GetKeyDown("n"))
        {
            
            currentZoneIndex = (currentZoneIndex + 1) % teleportationZones.Length;
            if (teleportationZones[currentZoneIndex] != null)
            {
                transform.position = teleportationZones[currentZoneIndex].position;
                
            }
            
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            transform.position = teleportationZones[3].position;
        }

        }

    //LE TEMPS ET LES COLLISIONS
       
    void OnTriggerEnter(Collider other)
    {



        if (other.gameObject.tag == "zone1"&& noZone==0) // Gare
        {
            tempsGare = canva.tempsjeu;
            string tempsEnregistre = canva.tempsdejeu.text;
            canva.tempsgarecoureur.text = tempsEnregistre;
            canva.tempsjeu = 0;
            noZone = 1;
            
        }
        else if (other.gameObject.tag == "zone2"&& noZone == 1) // Chantier
        {
            tempsChantier = canva.tempsjeu;
            string tempsChantierEnregistre = canva.tempsdejeu.text;
            canva.tempschantiercoureur.text = tempsChantierEnregistre;
            canva.tempsjeu = 0;
            noZone = 2;
        }
        else if (other.gameObject.tag == "zone3" ) // Forêt

        {
            // Rigidbody rb = GetComponent<Rigidbody>();
            //rb.velocity = new Vector3(0, 0, 0);

            BOUGER = false;

            tempsForet = canva.tempsjeu;
            string tempsForetEnregistre = canva.tempsdejeu.text;
            canva.tempsforetcoureur.text = tempsForetEnregistre;
            canva.tempsjeu = 0;
            
            


            canva.gare2.gameObject.SetActive(true);
            canva.chantier2.gameObject.SetActive(true);
            canva.foret2.gameObject.SetActive(true);
            canva.totaljoueur2.gameObject.SetActive(true);

            canva.meilleurstemps.gameObject.SetActive(true);
            canva.meilleurgare.gameObject.SetActive(true);
            canva.meilleurchantier.gameObject.SetActive(true);
            canva.meileurforet.gameObject.SetActive(true);
            canva.meilleurtotal.gameObject.SetActive(true);
            canva.nomgare.gameObject.SetActive(true);
            canva.nomchantier.gameObject.SetActive(true);
            canva.nomforet.gameObject.SetActive(true);
            canva.nomtotal.gameObject.SetActive(true);
            canva.meilleurtempsgare.gameObject.SetActive(true);
            canva.meilleurtempschantier.gameObject.SetActive(true);
            canva.meilleurtempsforet.gameObject.SetActive(true);
            canva.meilleurtempstotal.gameObject.SetActive(true);
            canva.nomducoureur.gameObject.SetActive(true);
            canva.nomjoueur.gameObject.SetActive(true);
            canva.démare.gameObject.SetActive(true);
            canva.Écran.gameObject.SetActive(true);
            canva.tempsdejeu.gameObject.SetActive(false);
            canva.nombretempsdejeu.gameObject.SetActive(false);


        }
        

      
        int tempsGareInt = (int)tempsGare;
        int tempsForetInt = (int)tempsForet;
        int tempsChantierInt = (int)tempsChantier;

        
        int totalTemps = tempsGareInt + tempsForetInt + tempsChantierInt;

        
        canva.tempstotalcoureur.text = totalTemps.ToString() + " secondes";


        //canva.tempstotalcoureur.text = (tempsForet + tempsChantier + tempsGare).ToString("F2")+"secondes";


        if (other.gameObject.tag == "train")
        {
            transform.position = teleportationZones[0].position;
            PenalitéGare = PenalitéGare + 1;
            canva.tempsjeu = PenalitéGare;

        }
        else if (other.gameObject.tag == "poutre")
        {
            transform.position = teleportationZones[1].position;
            PenalitéChantier = PenalitéChantier + 1;
            canva.tempsjeu = PenalitéChantier;
            
        }
        else if (other.gameObject.tag == "arbre")
        {
            transform.position = teleportationZones[2].position;
            PenalitéForet = PenalitéForet + 1;
            canva.tempsjeu = PenalitéForet;
            
        }

  
    }


}




























