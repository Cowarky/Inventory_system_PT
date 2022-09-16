using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "item", menuName = "items", order = 1)]
public class items : ScriptableObject
{
    public Sprite sprite;
    public string description;
    public bool isStackable;

    

}
