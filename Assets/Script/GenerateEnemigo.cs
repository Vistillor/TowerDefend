using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class GenerateEnemigo : MonoBehaviour
{

    public GameObject enemiguijo;


    public float enemyFrequency;

    //ultimo momento en el que se genero un enemigo
    private float lastEnemyTime;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Generacion de enemigo
       GenerateEnemiguito();
    }

    private void GenerateEnemiguito()
    {
        //comprueba si ha pasado el tiempo correspondiente desde el ultimo enemigo generado
        if (Time.time - lastEnemyTime >= enemyFrequency)
        {
            //Se genera un nuevo enemigo en la posicion del generador
            Instantiate(enemiguijo, transform.position, Quaternion.identity);
            //Registra el momento en que se ha generado
            lastEnemyTime = Time.time;
        }

       
    }
    private void GenerateEnemy()
    {
        //se genera un nuevo enemigo en la poscicion del generador
        Instantiate(enemiguijo, transform.position, Quaternion.identity);
    }
}
