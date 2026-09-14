using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson11_Practice : MonoBehaviour
{
    private float Direction = 1;
    void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Direction = 1;
            transform.position += transform.forward * 2.5f * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.forward * -2.5f * Time.deltaTime;
            Direction = -1;
        }           
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(transform.up * -30 * Direction * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(transform.up * 30 * Direction * Time.deltaTime);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
