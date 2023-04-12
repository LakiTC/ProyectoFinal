using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorObjectScript : MonoBehaviour
{
	public bool isBeingClicked;
	public void OnMouseDown()
	{
		isBeingClicked = true;
	}
	private void OnMouseUpAsButton()
	{
		isBeingClicked = false;
	}

	private void OnMouseExit()
	{
		if (isBeingClicked)
		{
			isBeingClicked = false;
		}
	}
}
