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

    void Update()
    {
        // Instancia una bala cada vez que el jugador pulsa el espacio
        if (Input.GetKeyDown(KeyCode.Space))
        {
           GameObject bala = Instantiate(bulletPrefab, transform.position + new Vector3(0, height, 0), Quaternion.identity);
            bala.GetComponent<Movimiento>().enemy = enemy;
        }
    }
}
