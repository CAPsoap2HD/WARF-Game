using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPlayer : MonoBehaviour
{
    public Collider2D perro;
    public Collider2D player;
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
            perro.enabled = false;
            player.enabled = false;
        }
     }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Perro")
        {
            perro.enabled = true;
            player.enabled = true;
        }
    }
}