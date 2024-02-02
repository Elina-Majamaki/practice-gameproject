using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class pistehallintakoodi1 : MonoBehaviour
{
    // Tässä ylläpidetään elämän määrää
    public float elamalaskuri = 300f;

    // Tähän tallennetaan kerätyt bitcoinit
    public float bitcoinit = 0f;

    // Tähän haetaan teksti1
    private GameObject t1 = null;
    // Tähän haetaan teksti1
    private GameObject t2 = null;

    void Start()
    {
        // Haetaan nämä valmiiksi
        this.t1 = GameObject.Find("teksti1");
        this.t2 = GameObject.Find("teksti2");
    } // Start

    
    void Update()
    {
        // Vähennetään elämälaskuria
        this.elamalaskuri -= Time.deltaTime * 10f;
        this.t1.GetComponent<Text>().text = "ELÄMÄ: " + this.elamalaskuri.ToString("0");

        this.t2.GetComponent<Text>().text = "BITCOINIT: " + this.bitcoinit.ToString("0.00") + "B";

        // Jos elämäpisteet loppu, niin Game Over
        if (this.elamalaskuri < 0f)
        {
            // Tallennetaan kerätyt bitcoinit
            PlayerPrefs.SetFloat("summa", this.bitcoinit);

            SceneManager.LoadScene("gameoverskene");
        } // if

    } // Update
} // class
