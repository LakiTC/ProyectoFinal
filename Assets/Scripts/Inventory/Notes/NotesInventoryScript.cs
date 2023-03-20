using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class NotesInventoryScript : MonoBehaviour
{
	/// <summary> Prefab de las notas </summary>
	[SerializeField] GameObject notePrefab;
	/// <summary> Donde van a instanciarse las notas al añadirse al inventario </summary>
	[SerializeField] Transform notesGrid;
	/// <summary> Contenido de las notas </summary>
	[SerializeField] TextMeshProUGUI content;

	/// <summary> Añade la nota al inventario </summary>
	public void AddNote(NotesScript note)
	{
		foreach (Transform n in notesGrid)		//Comprueba que la nota no exista ya
		{
			if (n.GetComponentInChildren<TextMeshProUGUI>().text == note.title)
			{
				return;
			}
		}
		GameObject newItemGameObject = Instantiate(notePrefab, notesGrid);
		newItemGameObject.name = note.name;
		newItemGameObject.GetComponentInChildren<TextMeshProUGUI>().text = note.title;
		newItemGameObject.GetComponent<Button>().onClick.AddListener(delegate { ChangeNote(note.content); });
	}

	/// <summary> Muestra el contenido de la nota</summary>
	public void ChangeNote(string _content)
	{
		content.SetText(_content);
	}

}
