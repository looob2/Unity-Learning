using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson14_Move : MonoBehaviour
{
    private void Move()
    {
        if (Input.GetKey(KeyCode.W))
            transform.position += transform.forward * 2 * Time.deltaTime;
        if (Input.GetKey(KeyCode.S))
            transform.position += transform.forward * -2 * Time.deltaTime;
        if (Input.GetKey(KeyCode.D))
            transform.position += transform.right * 2 * Time.deltaTime;
        if (Input.GetKey(KeyCode.A))
            transform.position += transform.right * -2 * Time.deltaTime;
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
