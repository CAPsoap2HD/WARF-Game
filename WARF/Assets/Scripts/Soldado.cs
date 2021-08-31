using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldado : MonoBehaviour
{
    public GameObject paracetamol;
    public GameObject soldado;
    public GameObject mochila;
    public GameObject soldado2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Paracetamol"))
        {
            Debug.Log("eee");
            Destroy(paracetamol);
            Destroy(soldado);
            Destroy(soldado2);
            mochila.SetActive(false);
        }


    }
    
}
