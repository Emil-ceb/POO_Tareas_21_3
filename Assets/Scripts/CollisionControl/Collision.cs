using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public float daño;

    public float heal;


    private void OnCollisionEnter(Collision other) {

        //Inicia la capsula
        if (other.gameObject.tag=="Player")
        {
            other.gameObject.GetComponent<CollisionControl>().damageP(daño);
            
        }

        //Termina


        if (other.gameObject.tag=="Player")
        {
            other.gameObject.GetComponent<CollisionControl>().cureP(heal);
            
        }   
    }
}
