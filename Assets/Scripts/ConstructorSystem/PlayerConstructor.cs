using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class PlayerConstructor
{
    public int playerId;
    public string name;
    public float health;
    public float speed;
    private Transform actualPosition;
    private int damage;


    public PlayerConstructor(int id, string n, float hp, float s){
        this.playerId=id;
        this.name=n;
        this.health=hp;
        this.speed=s;
        
    }
    
}
