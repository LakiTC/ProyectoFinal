using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable object/Note")]
public class NotesScript : ScriptableObject		//Scriptable de las notas
{
	/// <summary> Titulo de las notas </summary>
	public string title;
	/// <summary> Contenido de las notas</summary>
	public string content;
	
}
