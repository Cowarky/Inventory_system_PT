using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// public enum status {equipped, None};

[CreateAssetMenu]
public class item : ScriptableObject
{
    
    public Sprite image;
    public string description;
    public bool isStackable;
    public int amount;
    public bool equipped;


}
