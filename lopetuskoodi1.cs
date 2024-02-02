using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lopetuskoodi1t : MonoBehaviour
{

    void Update()
    {
       // Esc-näppäimellä voidaan lopettaa sovellus
       if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        } // if
    } // Update
} // class
