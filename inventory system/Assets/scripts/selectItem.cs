using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class selectItem : MonoBehaviour, IPointerClickHandler
{
    itemsAvailable items;
    // Parent of items

    void Start(){
        items = GetComponentInParent<itemsAvailable>();
    }

    public void OnPointerClick (PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Right){
            items.SelectItem(name);
        }else if (eventData.button == PointerEventData.InputButton.Left){
            items.CheckItemLocation(name);
        }
    }
    
}
