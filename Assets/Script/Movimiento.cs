using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [Tooltip("Velocidad de la bala")]
    public float bulletSpeed;

[Tooltip("enemimgo al que voy a matar")]
    public GameObject enemy; 

    

    void Start()
    {
        // La bala se destruirá a los 3 segundos para evitar problemas de memoria
        //Destroy(gameObject, 3);
    }

    void Update()
    {
        //comprueba si el enemigo existe o ya ha sido destruido
        if (enemy != null)
        {

            // Movimiento de la bala en el eje Y según la velocidad especificada
            transform.position = Vector3.MoveTowards(transform.position, enemy.transform.position, bulletSpeed);
            //transform.Translate(0, bulletSpeed, 0);

        }else
        {
            // si el enemigo se destruye se destruye la bala tambien
            Destroy(gameObject);
        }
    }


    

    
}
