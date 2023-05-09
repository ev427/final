using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    CharacterController _controller;
    public Transform target;
    GameObject Player;
    

    [SerializeField]
    float _moveSpeed = 5.0f;


    // Use this for initialization
    void Start()
    {
         

        Player = GameObject.FindWithTag("Player"); 
        target = Player.transform;
    


        _controller = GetComponent<CharacterController>();


    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target.position - transform.position;

        direction = direction.normalized;

        Vector3 velocity = direction * _moveSpeed;

        _controller.Move(velocity * Time.deltaTime);

        if(target != null)
        {
            transform.LookAt(target);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            Destroy(this.gameObject);
        }
    }
}
