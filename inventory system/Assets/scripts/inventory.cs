using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{
    public static inventory instance = null;
    public List<items> _items;
    public List<items> cells;
    public int listSize = 8;

    void Start(){
        instance = this;
    }

    void Update(){
        // if (Input.GetKeyDown(KeyCode.Space)){
            // if (cells.Count < 8){
                // items itm = new items();
                // itm.description = "test"+_items.Count;
                // itm.name = "testing"+_items.Count;
                // AddItem(itm);
                // AddToCells(itm);
            // }
        // }
        if (Input.GetKeyDown(KeyCode.E)){
            for (int i=0;i<cells.Count;i++){
                Debug.Log(cells[i].name);
            }
            // for (int i=0;i<_items.Count;i++){
            //     Debug.Log(_items[i].name);
            // }
        }
        
    }

    public void AddToCells(string name){
        for (int i=0;i<_items.Count;i++){
            if (name == _items[i].name){
                cells.Add(_items[i]);
            }
        }
        
    }

    public void RemoveItem(items itm){
        for (int i=0;i<_items.Count;i++){
            if (itm.name == _items[i].name){
                _items.Remove(itm);
            }
        }
        
    }
}
