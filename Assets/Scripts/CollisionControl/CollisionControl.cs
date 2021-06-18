using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionControl : MonoBehaviour
{

    Players playerData;
    
    // Start is called before the first frame update
    void Start()
    {
        playerData=GetComponentInParent<Players>();
        
    }

    public void damageP(){

        playerData.hp -=10;
    }
 
    public void damageP(float daño){

        playerData.hp -=daño;
    }

    public void cureP(float heal){

        playerData.hp +=heal; 
    }


}
