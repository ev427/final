using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artspawn : MonoBehaviour
{
    public GameObject art;
    public float XRange = 5.5f;
    public float ZRange = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(art, GenerateSpawnPosition(), art.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-XRange, XRange);
        float spawnPosZ = Random.Range(-ZRange, ZRange);
        Vector3 randomPos = new Vector3(spawnPosX, 1.5f, spawnPosZ);
        return randomPos;
    }
}
