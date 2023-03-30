using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshScript : MonoBehaviour
{
	[SerializeField] Transform targetDestination;           //Codigo para la navegacion del enemigo, aun no esta acabado
	[SerializeField] Vector3[] targetLocations;
	[SerializeField] GameObject[] doors;
	[SerializeField] Transform player;

	int currentPosition;
	int lastPosition = -1;

	NavMeshAgent _meshAgent;

	private void Start()
	{
		_meshAgent = GetComponent<NavMeshAgent>();
	}

	private void Update()
	{
		_meshAgent.destination = targetDestination.position;
		if (Input.GetKeyDown(KeyCode.K))
		{
			ChangeDestination(Random.Range(0, 3));
		}

		if (_meshAgent.remainingDistance <= 0.02f)
		{
			if (currentPosition != 0)
			{
				if (!doors[currentPosition - 1].activeSelf)
				{
					targetDestination = player;
					return;
				}
			}
			if (lastPosition != currentPosition)
			{
				if (currentPosition == 0)
				{
					StartCoroutine(WaitToChangeDestination(Random.Range(1, targetLocations.Length), 2.5f));
				}
				else
				{
					StartCoroutine(WaitToChangeDestination(0, 5f));
				}
			}
		}
	}

	public void ChangeDestination(int newDestination)
	{
		targetDestination.position = targetLocations[newDestination];
		lastPosition = currentPosition;
		currentPosition = newDestination;
	}

	IEnumerator WaitToChangeDestination(int position, float seconds)
	{
		yield return new WaitForSeconds(5);
		ChangeDestination(position);
		StopAllCoroutines();
	}
}
