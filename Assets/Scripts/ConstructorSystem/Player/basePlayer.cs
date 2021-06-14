using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basePlayer : MonoBehaviour
{

    public PlayerConstructor[] newPlayer;


    void Awake() 
    {
        newPlayer = new PlayerConstructor[2];

        newPlayer[0]=new PlayerConstructor(1, "Al",100, 5);
        newPlayer[1]=new PlayerConstructor(2, "Bel",80, 10);

    }

}
