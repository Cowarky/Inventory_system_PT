using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContextMenu : MonoBehaviour
{
    public void Use(){
        CraftingTable.instance.AddToTable(itemsAvailable.selectedItem);
        // Debug.Log(gameObject);
        // Debug.Log(gameObject.GetComponent<item>());
    }
    public void Examine(){
        item itm = itemsAvailable.selectedItem;
        Description.instance.ChangeSelectedItem(itm.name, itm.description, itm.image);
    }
}
