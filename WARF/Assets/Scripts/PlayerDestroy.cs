using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDestroy : MonoBehaviour
{

    public GameObject o;


   

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
           

            if (Input.GetKey(KeyCode.Space))
            {
              
                Destroy(o);
                
            }
        }
    }
}
