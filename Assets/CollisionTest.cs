using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollisionTest : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag = "HitBox")
        {
            print("DEATH");
        }
    }
}

