using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baseMob : MonoBehaviour
{

    public MobConstructor[] newMob;


    void Awake() 
    {
        newMob = new MobConstructor[3];

        newMob[0] = new MobConstructor(001, "Ghost",10, 10);
        newMob[1] = new MobConstructor(002, "Lesser Demon",50, 10);
        newMob[2] = new MobConstructor(003, "Skeleton",35, 5);

    }

}
