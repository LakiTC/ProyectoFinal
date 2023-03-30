using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LeverScript : MonoBehaviour
{
	[SerializeField]
	GameObject door;

	bool isMousePressed;

	public void OnMouseDown()
	{
		door.SetActive(false);
		print("ISPRESSED");
		isMousePressed = true;
	}
	private void OnMouseUpAsButton()
	{
		door.SetActive(true);
		isMousePressed = false;
	}

	private void OnMouseExit()
	{
		print("Has exited");
		if (isMousePressed)
		{
			door.SetActive(true);
			isMousePressed = false;
		}
	}
}
