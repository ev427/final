using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 10f;
    public float rotationSpeed = 100;
    public GameObject SliceAnim;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();

    }

    void Move()
    {
        float xValue = Input.GetAxis("Horizontal") * _moveSpeed * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * _moveSpeed * Time.deltaTime;
        
        transform.Translate(0f, 0f, zValue);
        transform.Rotate(Vector3.up, Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime);
    }

}
