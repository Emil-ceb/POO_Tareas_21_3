using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public int itemId;
    public string names;
    public float health;
    public float speed;

    baseItems bdItem = new baseItems();
    void Start()
    {
        bdItem = GameObject.FindObjectOfType<baseItems>();
        loadData(itemId);
        
    }
    void loadData(int id)
    {
        for (int i = 0; i < bdItem.newItem.Length; i++)
        {
            if (bdItem.newItem[i].itemId==id)
            {
                this.names=bdItem.newItem[i].name;
            }
            
        }

    }

   
}