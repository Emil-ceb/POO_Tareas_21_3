using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mobs : MonoBehaviour
{
    public int MobId;
    public string names;
    public float health;
    public float speed;

    baseMob bdMob = new baseMob();
    void Start()
    {
        bdMob = GameObject.FindObjectOfType<baseMob>();
        loadData(MobId);
        
    }
    void loadData(int id)
    {
        for (int i = 0; i < bdMob.newMob.Length; i++)
        {
            if (bdMob.newMob[i].MobId==id)
            {
                this.names=bdMob.newMob[i].name;
                this.health=bdMob.newMob[i].health;
                this.speed=bdMob.newMob[i].speed;
            }
            
        }

    }

   
}
