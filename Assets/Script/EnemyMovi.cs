using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovi : MonoBehaviour
{

    public NavMeshAgent agente;
    public Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        agente.SetDestination(position);
    }

   
}
