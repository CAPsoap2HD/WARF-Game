using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Movimiento2 : MonoBehaviour
{
    public float VelocidadMovimiento = 5.0f;
    public float VelocidadRotacion = 5.0f;
    public bool noPuedeMoverse;
    public GameObject ojoAbierto;

    public Movimiento2 movimiento2;
    public Movimiento movimiento;
    //public Patrulla patrulla;
    //public Patrulla2 patrulla2;


    public Rigidbody2D rb;
    public AudioSource caminata;

    public CapsuleCollider2D humano;
    public CapsuleCollider2D perro;


    public float speed = 4f;

    private void Update()
    {



        if (Input.GetKeyDown(KeyCode.Q))
        {

            movimiento.enabled = true;
            movimiento2.enabled = false;
            //patrulla.enabled = false;
            //patrulla2.enabled = true;
            //humano.enabled = true;
            //perro.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            //patrulla.enabled = false;
            //patrulla2.enabled = false;
            if (Input.GetKeyDown(KeyCode.E))
            {
                //patrulla.enabled = false;
                //patrulla2.enabled = true;



            }


        }

        Vector3 mov = new Vector3(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical"),
            0

            );

        transform.position = Vector3.MoveTowards(transform.position, transform.position + mov, speed * Time.deltaTime);


    }
}
