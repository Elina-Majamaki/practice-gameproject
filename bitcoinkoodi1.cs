using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bitcoinkoodi1 : MonoBehaviour
{
    // Tähän arvotaan nopeus
    private float nopeus = 1f;

    // Tähän raahataan paukku
    public GameObject paukku = null;

    // Tähän haetaan koodivarasto
    private GameObject koodit = null;

    void Start()
    {
        // Arvotaan lentonopeus
        this.nopeus = Random.Range(0.5f, 5f);

        // Haetaan valmiiksi
        this.koodit = GameObject.Find("koodivarasto");
    } // Start

    
    void Update()
    {
        // Lennätetään kolikkoa
        this.GetComponent<Transform>().Translate(-this.nopeus * Time.deltaTime, 0f, 0f);

        // Tuhotaan kun on poistuttu näytöltä
        if (this.GetComponent<Transform>().position.x < -15f)
        {
            Destroy(this.gameObject);
        }
    } // Update

    // Reagoidaan triggeriin
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Oliko törmääjä pantteri
        if (collision.name.Equals("pantteri1"))
        {
            Debug.Log("OSUI!");
            // Soitetaan ääniefekti
            GameObject.Find("aaniolio").GetComponents<AudioSource>()[1].Play();

            // Päivitetään Bitcoin-laskuria
            this.koodit.GetComponent<pistehallintakoodi1>().bitcoinit += 1f;

            // Luodaan räjähdysanimaatio
            GameObject apupaukku = Instantiate(this.paukku, this.GetComponent<Transform>().position,
                                                             Quaternion.identity);
            // Tuhotaan räjähdysolio 5s kuluttua
            Destroy(apupaukku, 5f);
            Destroy(this.gameObject);
        } // if
    } // OnTriggerEnter2D
} // class
