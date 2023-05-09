using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class axeforward : MonoBehaviour
{
    public float moveSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

        public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        if(other.gameObject.CompareTag("Door"))
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
    }
}
