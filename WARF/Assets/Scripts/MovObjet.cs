using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovObjet : MonoBehaviour
{

    public GameObject barril;

    public Rigidbody2D rb;
   
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        
    
    
        if (collision.tag == "Player")
        {

            //barril.transform.position = Vector3.left;

            rb.AddForce(Vector2.right*3);
        }

        
    }
}
