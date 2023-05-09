using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemarro : MonoBehaviour
{
     public float moveSpeed = 25;
    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            //Destroy(other.gameObject);
            //Destroy(this.gameObject);
        }
        if(other.gameObject.CompareTag("Wall"))
        {
            Destroy(this.gameObject);
        }
    }
}
