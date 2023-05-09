using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemshoot : MonoBehaviour
{
        public GameObject bullet;
        public int bullet_rate = 35;
        public int timer;
        public Transform SpawnPoint;

        void Start()
        {
            timer = bullet_rate * 35;
        }
    
        // Update is called once per frame
        void Update()
        {
            if (timer == 0)
            {
                Instantiate(bullet, SpawnPoint.transform);
                timer = bullet_rate * 35;
            }
            else
            {
                timer -= 1;
            }
        }
}
