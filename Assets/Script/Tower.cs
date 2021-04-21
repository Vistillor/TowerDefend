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

    public float ratio;

    private void Start()
    {
        InvokeRepeating("Shoot", 3, ratio);
    }

    void Update()
    {
        // Instancia una bala cada vez que el jugador pulsa el espacio
      //  if (Input.GetKeyDown(KeyCode.Space))
        {
            //comprueba si el enemigo existe o ya ha sido destruido
           
        }

       
    }
    private void Shoot()
    {
        if (enemy != null)
        {
            GameObject bala = Instantiate(bulletPrefab, transform.position + new Vector3(0, height, 0), Quaternion.identity);
            bala.GetComponent<Movimiento>().enemy = enemy;
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
}
