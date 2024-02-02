using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pantterikoodi1 : MonoBehaviour
{
    // Tällä kerrotaan suunta 1=oikealle 2=vasemmalle
    private int suunta = 1;

    // Tällä määrätään hypyn voima
    private float hyppyvoima = 400f;

    void Start()
    {
        
    } // Start

    void Update()
    {
        // Nuolinäppäimillä kävellään
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            // Käännetään pantteri tarvittaessa
            if (this.suunta == 2)
            {
                this.GetComponent<Transform>().Rotate(0f, 180f, 0f);
                this.suunta = 1;
            } // if

            this.GetComponent<Animator>().SetInteger("pantteritila", 1);
        } // if

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            this.GetComponent<Animator>().SetInteger("pantteritila", 0);
        } // if

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
        {
            this.GetComponent<Transform>().Translate(1f * Time.deltaTime, 0f, 0f);
        } // if

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // Käännetään pantteri tarvittaessa
            if (this.suunta == 1)
            {
                this.GetComponent<Transform>().Rotate(0f, 180f, 0f);
                this.suunta = 2;
            } // if

            this.GetComponent<Animator>().SetInteger("pantteritila", 1);
        } // if

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            this.GetComponent<Animator>().SetInteger("pantteritila", 0);
        } // if

        // Pantteri hyppää
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Sallitaan hyppääminen vain kävelystä
            if (this.GetComponent<Animator>().GetInteger("pantteritila") == 1)
            {
                this.GetComponent<Animator>().SetInteger("pantteritila", 2);
                this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 1f) * this.hyppyvoima);
            } // if
        } // if

    } // Update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Palautetaan kävely, kun pantteri tulee alas
        this.GetComponent<Animator>().SetInteger("pantteritila", 1);
    } // OnCollisionEnter2D

    private void OnTriggerExit2D(Collider2D collision)
    {
        // Ilmalennon ajaksi vaihdetaan animaatio
        this.GetComponent<Animator>().SetInteger("pantteritila", 2);
    } // OnCollisionExit2D

} // class
