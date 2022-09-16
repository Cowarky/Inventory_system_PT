using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class inputManager : MonoBehaviour, IPointerClickHandler
{
    inventory inv;
    void Start(){
        inv = inventory.instance;
    }
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        // GameObject obj = EventSystem.current.currentSelectedGameObject;
        inventory.instance.AddToCells(name);
    }
}
