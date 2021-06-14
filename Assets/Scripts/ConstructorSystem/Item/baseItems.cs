using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baseItems : MonoBehaviour
{
    public ItemContructor [] newItem;
    
    private void Awake() 
    {
        newItem = new ItemContructor[2];

        newItem[0] = new ItemContructor(01,"Heal gem");
        newItem[1] = new ItemContructor(02,"Coin");
        
    }
}
