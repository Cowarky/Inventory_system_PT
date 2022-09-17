using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemsAvailable : MonoBehaviour
{
    [SerializeField] private List<item> items;
    [SerializeField] private GameObject parent;
    [SerializeField] private GameObject panel;
    [SerializeField] private inventory _inventory;
    public status state = status.equipped;

    void Start(){
        
    }

    void GetAllItems(){
        
    }
    public void CheckItemLocation(string name){
        foreach(item itm in items){
            if (name == itm.name){
                if (state == itm.equipped){
                    RemoveItem(name);
                    itm.equipped = status.None;
                }
                else {
                    AddItem(name);
                    itm.equipped = status.equipped;
                }
            }
        }
    }
    void AddItem(string name){
        Transform[] children = parent.GetComponentsInChildren<Transform>();
        foreach (Transform child in children){
            if (child.name == name){
                child.SetParent(panel.transform);
                child.SetSiblingIndex(0);
            }
        }
    }
    void RemoveItem(string name){
        Transform[] children = panel.GetComponentsInChildren<Transform>();
        foreach (Transform child in children){
            if (child.name == name){
                child.SetParent(parent.transform);
                child.SetSiblingIndex(0);
            }
        }
    }
}
