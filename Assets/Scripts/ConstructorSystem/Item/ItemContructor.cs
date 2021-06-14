using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemContructor
{
    public int itemId;
    public string name;
    private Transform actualPosition;

    public ItemContructor(int id, string n){
        this.itemId = id;
        this.name = n;
    }

}
