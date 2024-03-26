using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour
{
    Vector3 ImpulseVector = new Vector3(0.0f, 5000.0f, 10000.0f);
    Vector3 spinVector = new Vector3(50000.0f, 50000.0f, 50000.0f);
  
    

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            StartCoroutine(Collide());
        }
        
        
    }

    IEnumerator Collide()
    {


        //statsScript.paused = true;
        Time.timeScale = 0;
        
        yield return new WaitForSecondsRealtime(1f);

        Time.timeScale = 1;

        //statsScript.paused = false;
        transform.parent = null;
        GetComponent<Rigidbody>().AddForce(ImpulseVector, ForceMode.Force);
        GetComponent<Rigidbody>().AddTorque(spinVector, ForceMode.Force);
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Collider>().enabled = false; 

        yield return new WaitForSecondsRealtime(3f);
        Destroy(gameObject);
    }
}
