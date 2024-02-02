using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Scenemanager
using UnityEngine.SceneManagement;

public class introkoodi1 : MonoBehaviour
{
    
    void Start()
    {
        DontDestroyOnLoad(GameObject.Find("introaaniolio"));
    } // Start

    void Update()
    {
        // Kun käyttäjä painaa jotain näppäintä, jatketaan peliin
        if (Input.anyKey)
        {
            SceneManager.LoadScene("peliskene");
        } // if
        
    } // Update
} // class
