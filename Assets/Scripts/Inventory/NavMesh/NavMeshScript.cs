using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshScript : MonoBehaviour
{
	[SerializeField] Transform destination;				//Codigo para la navegacion del enemigo, aun no esta acabado


	NavMeshAgent _meshAgent;

	private void Start()
	{
		_meshAgent = GetComponent<NavMeshAgent>();
	}

	private void Update()
	{
		_meshAgent.destination = destination.position;
	}
}
