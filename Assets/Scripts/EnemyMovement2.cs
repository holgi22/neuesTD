using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement2 : MonoBehaviour {

    public NavMeshAgent navmeshagent;

    public void Setdestination(Vector3 dest)
    {
        navmeshagent.SetDestination(dest);
    }    
    
    
}
