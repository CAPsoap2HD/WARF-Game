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

    public Movimiento movimiento;
    //public Movimiento2 mv;



    public Rigidbody2D rb;
    public AudioSource caminata;

    public float speed = 4f;

    private void Update()
    {



        if (Input.GetKeyDown(KeyCode.Q))
        {



            //mv.enabled = true;

            movimiento.enabled = false;








        }

        if (Input.GetKeyDown(KeyCode.Space))
        {




        }

        if (Input.GetKeyUp(KeyCode.Space))
        {




        }

        Vector3 mov = new Vector3(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical"),
            0

            );

        transform.position = Vector3.MoveTowards(transform.position, transform.position + mov, speed * Time.deltaTime);


    }
}
