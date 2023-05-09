using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrowshoot : MonoBehaviour
{
    public GameObject BulletPrefab;
    public GameObject AxePrefab;
    public GameObject AxeReal;
    public GameObject SpawnPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(BulletPrefab, transform.position, SpawnPos.transform.rotation);
        }

        if(Input.GetMouseButtonDown(1))
        {
            Instantiate(AxePrefab, transform.position, SpawnPos.transform.rotation);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(AxeReal, transform.position, SpawnPos.transform.rotation);
        }
    }
}
