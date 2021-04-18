using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoBala : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //Comprueba si es un enemigo con el que choca
        if (collision.gameObject.CompareTag("enemigo")) {

            --collision.gameObject.GetComponent<Vidas>().salud;

        }



        // La bala se destruye en cuanto colisiona con algún objeto
        Destroy(gameObject);
    }
}
