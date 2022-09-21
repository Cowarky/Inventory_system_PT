using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftingTable : MonoBehaviour
{

    // OLD
    public static CraftingTable instance = null;
    [SerializeField] private GameObject table;
    [SerializeField] private List<item> reciepiesAvailable;
    [SerializeField] private List<item> itemsInTable;
    [SerializeField] private Image firstIngredient;
    [SerializeField] private Image secondIngredient;
    [SerializeField] private itemsAvailable items;

    void Start(){
        instance = this;
    }

    public void GetItemsFromTable(){
        Transform[] children = table.GetComponentsInChildren<Transform>();
        for (int i=1; i<children.Length; i=i+2){
            itemsInTable.Add(items.GetItem(children[i].name));
        }
    }
    public void AddToTable(item itm){
        if (!items.CheckItemExists(itm.name)) {
            return;
        }
        if (itemsInTable.Count != 2){
            itemsInTable.Add(items.GetItem(itm.name));
            ChangeCell(itemsInTable.Count, itm);
            // items.ChangeItemLocation(itm, items.GetInventoryGameObject(), table, itemsInTable.Count);
        }
    }
    void ChangeCell(int idx, item itm){
        Transform[] children = table.GetComponentsInChildren<Transform>();
        for (int i=1;i<children.Length;i=i+2){
            children[i].GetComponent<Image>().sprite = itm.image;
        }
    }
    void RemoveCell(int idx){
        Transform[] children = table.GetComponentsInChildren<Transform>();
        Destroy(children[idx].gameObject);
    }




}
