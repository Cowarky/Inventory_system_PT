using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{
    public int inventoryMaxSize;
    public List<item> itemsInInventory;
    public GameObject _inventory;


    void Awake(){
        
    }

    public bool AddItemToInventory(item itm){
        if (CheckIfExists(itm) && itm.isStackable){
            // GetItem(itm.name).amount++;
            AddAmount(itm, 1);
            return true;
        }else if (!CheckIfExists(itm) && !CheckIfFull()){
            itemsInInventory.Add(itm);
            return true;
        }else {
            return false;
        }
    }
    public bool RemoveItemFromInventory(item itm){
        if (CheckIfExists(itm)){
            itemsInInventory.Remove(itm);
            return true;
        }
        return false;
    }
    public void AddAmount(item itm, int amount){
        GetItem(itm.name).amount += amount;
    }
    public bool CheckIfExists(item itm){
        if (itemsInInventory.Contains(itm)){
            return true;
        }
        return false;
    }

    public item GetItem(string name){
        item finalItem = null;
        foreach(item itm in itemsInInventory){
            if (itm.name == name){
                finalItem = itm;
            }
        }
        return finalItem;
    }
    bool CheckIfFull(){
        if (itemsInInventory.Count != inventoryMaxSize){
            return false;
        }
        return true;
    }




}
