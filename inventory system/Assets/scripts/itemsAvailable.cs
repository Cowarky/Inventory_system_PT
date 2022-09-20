using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemsAvailable : MonoBehaviour
{
    [SerializeField] private List<item> items;
    [SerializeField] private GameObject ItemsGameObject;
    [SerializeField] private GameObject inventoryGameObject;
    [SerializeField] private inventory _inventory;

    public static item selectedItem = null;

    public void CheckItemLocation(string name){
        
        foreach(item itm in items){
            if (!_inventory.CheckIfExists(itm)){
            
                if (name == itm.name){
                    if (_inventory.AddItemToInventory(itm)){
                        AddItem(name);
                        itm.equipped = !itm.equipped;
                    }
                }

            }
            else {
                if (name == itm.name){
                    if (!itm.equipped){
                        if (itm.isStackable){
                            _inventory.AddItemToInventory(itm);
                            // itm.equipped = !itm.equipped;
                            DeleteItem(itm.name);
                        }
                    }
                    else {
                        _inventory.RemoveItemFromInventory(itm);
                        RemoveItem(itm.name);
                        itm.equipped = !itm.equipped;
                    }
                }
            }
        }

    }
    void AddItem(string name){
        Transform[] children = ItemsGameObject.GetComponentsInChildren<Transform>();
        foreach (Transform child in children){
            if (child.name == name){
                child.SetParent(inventoryGameObject.transform);
                child.SetSiblingIndex(0);
            }
        }
    }
    void RemoveItem(string name){
        Transform[] children = inventoryGameObject.GetComponentsInChildren<Transform>();
        foreach (Transform child in children){
            if (child.name == name){
                child.SetParent(ItemsGameObject.transform);
                child.SetSiblingIndex(0);
            }
        }
    }
    void DeleteItem(string name){
        Transform[] children = inventoryGameObject.GetComponentsInChildren<Transform>();
        foreach (Transform child in children){
            if (child.name == name){
                Destroy(child.gameObject);
            }
        }
    }
    public void SelectItem(string name){
        if (_inventory.CheckIfExists(_inventory.GetItem(name))){
            foreach (item itm in _inventory.itemsInInventory){
                if (itm.name == name){
                    selectedItem = itm;
                }
            }
        }
    }
}
