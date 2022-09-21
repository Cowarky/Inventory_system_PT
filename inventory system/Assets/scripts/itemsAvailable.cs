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
            if (name == itm.name) {

                if (!_inventory.CheckIfExists(itm)){

                    if (_inventory.AddItemToInventory(itm)){
                        AddItem(name);
                    }

                }else {
                    if (!itm.equipped) {

                        if (itm.isStackable){
                            _inventory.AddItemToInventory(itm);
                            DeleteItem(name);
                        }else {
                            _inventory.RemoveItemFromInventory(itm);
                            RemoveItem(name);
                        }

                    }
                }
                itm.equipped = !itm.equipped;

            }
        }

    }
    public void ChangeItemLocation (item itm, GameObject from, GameObject to, int idx){
        Transform[] children = from.GetComponentsInChildren<Transform>();
        foreach (Transform child in children){
            if (child.name == itm.name){
                child.SetParent(to.transform);
                child.SetSiblingIndex(idx);
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
    public bool CheckItemExists(string name){
        foreach (item itm in items){
            if (itm.name == name){
                return true;
            }
        }
        return false;
    }
    public item GetItem(string name){
        foreach (item itm in items){
            if (itm.name == name)
                return itm;
        }
        return null;
    }
    public GameObject GetInventoryGameObject(){
        return inventoryGameObject;
    }
}
