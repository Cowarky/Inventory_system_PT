using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Description : MonoBehaviour
{
    public static Description instance = null;
    [SerializeField] private TMP_Text _name;
    [SerializeField] private TMP_Text description;
    [SerializeField] private Image _image;

    void Start(){
        instance = this;
    }

    public void ChangeSelectedItem(string name, string description, Sprite image){
        _name.text = name;
        this.description.text = description;
        this._image.sprite = image;
    }
}
