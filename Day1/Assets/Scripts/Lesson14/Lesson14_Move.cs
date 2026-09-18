using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson14_Move : MonoBehaviour
{
    private void Move()
    {
        if (Input.GetKey(KeyCode.W))
            transform.position += transform.forward * Time.deltaTime;
        if (Input.GetKey(KeyCode.S))
            transform.position += transform.forward * -1 * Time.deltaTime;
        if (Input.GetKey(KeyCode.D))
            transform.position += transform.right * Time.deltaTime;
        if (Input.GetKey(KeyCode.A))
            transform.position += transform.right * -1 * Time.deltaTime;
        if (Input.GetKeyUp(KeyCode.Space))
            transform.position += Vector3.up * 200 * Time.deltaTime;
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
