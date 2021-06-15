using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionControl : MonoBehaviour
{
    Players playerData;

    private void Start() 
    {
        playerData=GetComponentInParent<Players>();
    }
    public void damageP(float damage)
    {
        playerData.health -=damage;

    }
    public void healP(float heal)
    {
        playerData.health -=heal;

    }
}
