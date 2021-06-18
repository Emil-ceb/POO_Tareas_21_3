using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    public int playerId;
    public string names;
    public float hp;
    public float speed;

    basePlayer bdPlayer = new basePlayer();
    void Start()
    {
        bdPlayer = GameObject.FindObjectOfType<basePlayer>();
        loadData(playerId);
        
    }
    void loadData(int id)
    {
        for (int i = 0; i < bdPlayer.newPlayer.Length; i++)
        {
            if (bdPlayer.newPlayer[i].playerId==id)
            {
                this.names=bdPlayer.newPlayer[i].name;
                this.hp=bdPlayer.newPlayer[i].health;
                this.speed=bdPlayer.newPlayer[i].speed;
            }
            
        }

    }

   
}
