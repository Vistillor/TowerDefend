using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vidas : MonoBehaviour
{
   [Tooltip("Puntos de vida")]
    public int salud;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //controla que al quedarse sin vidas el enemigo se destruya
        if (salud <= 0)
        {
            Destroy(gameObject);
        }
    }
}
