using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{
    public static inventory instance = null;
    public int inventorySize;
    public List<item> itemsInInventory;
    public GameObject _inventory;


    void Awake(){
        inventorySize = _inventory.GetComponentsInChildren<Transform>().Length;
        instance = this;
    }

    public void AddItemToInventory(item itm){
        // if (!itemsInInventory.Contains(itm)){
        //     itemsInInventory.Add(itm);
        // }
    }
    public void CheckIfExists(){
        
    }




}
