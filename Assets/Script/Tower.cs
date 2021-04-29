using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [Tooltip("Referencia al prefab de la bala")]
    public GameObject bulletPrefab;

    [Tooltip("Referencia al enemigo al que voy a disparar")]
    public GameObject enemy;

    public float height;

   

    

    [Tooltip("frecuencia de disparo deseada, cada cuantos s se dispara")]
    public float shootfrecuencia;

    private float lastShotTime;



    private void Update()
    {
        Shoot();
    }
    private void Shoot() { 
        if (enemy != null)
        {
            //comprueba si ha pasado el tiempo correspondiente desde el último disparo
            if (Time.time - lastShotTime >= shootfrecuencia)
            {
                //realiza el disparo instanciado la bala
                GameObject bala = Instantiate(bulletPrefab, transform.position + new Vector3(0, height, 0), Quaternion.identity);
                //Asigna a la bala instaciada el enemigo al que tiene que dirigirse
                bala.GetComponent<Movimiento>().enemy = enemy;
                //regista el momento en el que se ha disparado
                lastShotTime = Time.time;
            }
        }


    }

  


    
    private void OnTriggerEnter(Collider other)
    {
        //combrueba si es el enemigo el que entra en el collaider
        if (other.CompareTag("enemigo"))
        {
            enemy = other.gameObject;
        }

        
    }
    private void OnCollisionExit(Collision collision)
    {
        enemy = null;
    }

}
