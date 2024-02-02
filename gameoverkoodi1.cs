using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Jotta UI-elementit näkyisivät
using UnityEngine.UI;

public class gameoverkoodi1 : MonoBehaviour
{
    
    void Start()
    {
        // Haetaan tallennettu summa ja tulostetaan se coinit-kenttään
        float summa = PlayerPrefs.GetFloat("summa");
        GameObject.Find("coinit").GetComponent<Text>().text = "KERÄTYT BITCOINIT: " + summa.ToString("0.00") + "B";
    } // Start

    
    void Update()
    {
        
    } // Update
} // class
