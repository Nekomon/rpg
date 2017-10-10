using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class PlayerMotor : MonoBehaviour {

    NavMeshAgent agente;

	// Use this for initialization
	void Start () {
        agente = GetComponent<NavMeshAgent>();
	}
	
	
    public void MoveToPoint (Vector3 point)
    {
        agente.SetDestination(point);
    }
	
}
