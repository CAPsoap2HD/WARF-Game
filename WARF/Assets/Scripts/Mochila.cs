using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mochila : MonoBehaviour
{
    public GameObject mochila;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        
          
            

     
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Perro")
        {

            
            mochila.SetActive(true);
           
        }
        
       
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Perro")
        {
            mochila.SetActive(false);
           
        }
    }
}
