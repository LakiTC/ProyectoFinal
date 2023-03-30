using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraTestScript : MonoBehaviour
{
	public GameObject player;
	public float sensitivity;

	void Start()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
		}
	}
	void FixedUpdate()
	{
		float rotateHorizontal = -Input.GetAxis("Mouse X");
		float rotateVertical = Input.GetAxis("Mouse Y");
		transform.RotateAround(player.transform.position, -Vector3.up, rotateHorizontal * sensitivity);
		//transform.RotateAround(Vector3.zero, transform.right, rotateVertical * sensitivity);

	   // transform.Rotate(-transform.up * rotateHorizontal * sensitivity);
		//transform.Rotate(transform.right * rotateVertical * sensitivity);
	}

	
}
