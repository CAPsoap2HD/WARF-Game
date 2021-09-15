using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barril : MonoBehaviour
{

   public  Collider2D barril;
    public Rigidbody2D rb;
    

    public void OnTriggerStay2D(Collider2D collision)
    {
        //if (collision.tag == "barril")
        //{
        //    barril.enabled = true;
        //}
       
        if(collision.tag == "barril")
        {
            rb.bodyType = RigidbodyType2D.Kinematic;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        //if(collision.tag == "barril")
        //{
        //    barril.enabled = false;
        //}

        if (collision.tag == "barril")
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
        }
    }
}
