using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class MobConstructor
{
    public int MobId;
    public string name;
    public float health;
    public float speed;
    private Transform actualPosition;
    private int damage;


    public MobConstructor(int id, string n, float hp, float s)
    {
        this.MobId=id;
        this.name=n;
        this.health=hp;
        this.speed=s;
        
    }
    
}
