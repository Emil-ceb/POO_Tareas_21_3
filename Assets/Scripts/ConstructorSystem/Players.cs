using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    public int playerId;
    public string name;
    public float health;
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
                this.name=bdPlayer.newPlayer[i].name;
                this.health=bdPlayer.newPlayer[i].health;
                this.speed=bdPlayer.newPlayer[i].speed;
            }
            
        }

    }

   
}
