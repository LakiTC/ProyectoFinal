using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(menuName = "Scriptable object/Item")]
public class ItemsScript : ScriptableObject
{
    /// <summary> Imagen del item </summary>
    public Sprite image;
    /// <summary> Tipo de item </summary>
    public ItemType type;
    /// <summary> Accion del item </summary>
    public ActionType action;
    /// <summary> Si es stackeable </summary>
    public bool stackable = true;
}

/// <summary> Tipos de Items </summary>
public enum ItemType                //Ejemplos
{
    Tuberias,
    Llaves,
    Otros
}

/// <summary> Tipos de acciones </summary>

public enum ActionType              //Ejemplos, pueden cambiarse para cosas como abrir puertas o lo que sea necesario. 
{
    Dig,
    Mine
}
