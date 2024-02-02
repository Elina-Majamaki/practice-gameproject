using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kolikkotehdaskoodi1 : MonoBehaviour
{
    // Tähän raahataan kolikon Prefab
    public GameObject kolikko = null;

    private float laskuri = 0f;

    void Start()
    {
        
    } // Start

    
    void Update()
    {

        this.laskuri += Time.deltaTime;

        if (this.laskuri > 0.5f)
        {
            // Luodaan uusia kolikoita lennosta
            GameObject apukolikko1 = Instantiate(this.kolikko, new Vector3(Random.Range(11f, 15f),
                                                          Random.Range(-3f, 5f), 0f),
                                                          Quaternion.identity);
            this.laskuri = 0f;
        } // if

    } // Update
} // class
