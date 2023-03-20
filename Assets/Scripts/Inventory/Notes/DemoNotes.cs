using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary> Misma funcion que el DemoScript para las notas </summary>
public class DemoNotes : MonoBehaviour
{
	/// <summary> Inventario de notas </summary>
	public NotesInventoryScript notesInventory;
	/// <summary> Lista de notas recogibles </summary>
	public NotesScript[] notesToPickup;                 //Posiblemente lo convierta en un JSON para hacerlo mejor si es necesario

	/// <summary> Recoge la nota deseada a traves de su id (Posicion en notesToPickup)</summary>
	public void PickupNote(int id)
	{
		notesInventory.AddNote(notesToPickup[id]);
	}
}
