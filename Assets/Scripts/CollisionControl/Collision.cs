using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public float damage;
    public float heal;

    private void OnCollisionEnter(Collision other)
     {

        if (other.gameObject.tag=="Player")
        {
            other.gameObject.GetComponent<CollisionControl>().damageP(damage);
        }

        if (other.gameObject.tag=="Player")
        {
            other.gameObject.GetComponent<CollisionControl>().healP(heal);
        }
        
    }
}
