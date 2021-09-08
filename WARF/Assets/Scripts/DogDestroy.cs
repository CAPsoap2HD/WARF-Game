using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogDestroy : MonoBehaviour
{
    
    public Collider2D perro;


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Perro")
        {
            perro.enabled = false;
           
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Perro")
        {
            perro.enabled = true;
           
        }
    }
}
