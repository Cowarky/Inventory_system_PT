using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.EventSystems;

public class ContextMenu : MonoBehaviour
{

    public void Examine(){
        item itm = itemsAvailable.selectedItem;
        Description.instance.ChangeSelectedItem(itm.name, itm.description, itm.image);
    }
}
