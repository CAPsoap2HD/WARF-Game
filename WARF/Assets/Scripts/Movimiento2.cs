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
    public Movimiento2 mv;
    public Patrulla P;

    public NavMeshAgent Humano;
    public NavMeshAgent Perro;

    public Rigidbody rb;
    public AudioSource caminata;
    private void Update()
    {
        MoveInDirectionOfInput();

        if (Input.GetKeyDown(KeyCode.Q))
        {
            mv.enabled = false;

            movimiento.enabled = true;



            P.enabled = true;

            Humano.enabled = false;

            Perro.enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Humano.enabled = false;


        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Humano.enabled = true;



        }
    }
    public void MoveInDirectionOfInput()
    {
        if (!noPuedeMoverse)
        {
            Vector3 dir = Vector3.zero;

            dir.x = Input.GetAxis("Horizontal");
            dir.z = Input.GetAxis("Vertical");
            //AudioManager.obj.playWalk();

            Vector3 camDirection = Camera.main.transform.rotation * dir; //This takes all 3 axes (good for something flying in 3d space)    
            Vector3 targetDirection = new Vector3(camDirection.x, 0, camDirection.z); //This line removes the "space ship" 3D flying effect. We take the cam direction but remove the y axis value

           

            rb.velocity = targetDirection.normalized * VelocidadMovimiento;     //normalized prevents char moving faster than it should with diagonal input
        }

    }

   
}
