using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson11_Practice : MonoBehaviour
{
    void Move()
    {
        if (Input.GetKey(KeyCode.W))
            transform.position += transform.forward * 1 * Time.deltaTime;
        if (Input.GetKey(KeyCode.S))
            transform.position += transform.forward * -1 * Time.deltaTime;
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(new Vector3(0, 1, 0) * -0.1f);
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(new Vector3(0, 1, 0) * 0.1f);
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
