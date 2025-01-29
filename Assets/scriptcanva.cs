using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scriptcanva : MonoBehaviour
{
    public TMP_Text tempsdejeu;
    public TMP_Text nombretempsdejeu;
    public TMP_Text gare;
    public TMP_Text chantier;
    public TMP_Text vostemps;
    public TMP_Text tempsgarecoureur;
    public TMP_Text tempschantiercoureur;
    public TMP_Text tempsforetcoureur;
    public TMP_Text tempstotalcoureur;
    public TMP_Text foret;
    public TMP_Text totaljoueur;
    public TMP_Text chantier2;
    public TMP_Text gare2;
    public TMP_Text foret2;
    public TMP_Text totaljoueur2;
    public TMP_Text meilleurstemps;
    public TMP_Text meilleurgare;
    public TMP_Text meilleurchantier;
    public TMP_Text meileurforet;
    public TMP_Text meilleurtotal;
    public TMP_Text nomgare;
    public TMP_Text nomchantier;
    public TMP_Text nomforet;
    public TMP_Text nomtotal;
    public TMP_Text meilleurtempsgare;
    public TMP_Text meilleurtempschantier;
    public TMP_Text meilleurtempsforet;
    public TMP_Text meilleurtempstotal;
    public TMP_Text nomducoureur;
    public TMP_InputField nomjoueur;


    public Button démare;
    public Image Écran;


    //letemps:


    public float tempsjeu = 0;
    public bool Déroulement = false;

    //quand on démarre le jeu
    public void démarrer()
    {
        gare2.gameObject.SetActive(false);
        chantier2.gameObject.SetActive(false);
        foret2.gameObject.SetActive(false);
        totaljoueur2.gameObject.SetActive(false);

        meilleurstemps.gameObject.SetActive(false);
        meilleurgare.gameObject.SetActive(false);
        meilleurchantier.gameObject.SetActive(false);
        meileurforet.gameObject.SetActive(false);
        meilleurtotal.gameObject.SetActive(false);
        nomgare.gameObject.SetActive(false);
        nomchantier.gameObject.SetActive(false);
        nomforet.gameObject.SetActive(false);
        nomtotal.gameObject.SetActive(false);
        meilleurtempsgare.gameObject.SetActive(false);
        meilleurtempschantier.gameObject.SetActive(false);
        meilleurtempsforet.gameObject.SetActive(false);
        meilleurtempstotal.gameObject.SetActive(false);
        nomducoureur.gameObject.SetActive(false);
        nomjoueur.gameObject.SetActive(false);
        démare.gameObject.SetActive(false);
        Écran.gameObject.SetActive(false);
        

        //letemps
        tempsjeu = 0; 
        Déroulement = true;

        vostemps.text = "temps intermédiaire";






    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Déroulement)
        {
            tempsjeu += Time.deltaTime;
            int minutes = (int)tempsjeu / 60;
            int secondes = (int)tempsjeu % 60;
            tempsdejeu.text = $"{minutes:00}:{secondes:00}";
        }
    }

  
   }
    





