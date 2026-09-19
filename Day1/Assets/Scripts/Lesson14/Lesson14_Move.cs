using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson14_Move : MonoBehaviour
{
    private void Move()
    {
        if (Input.GetKey(KeyCode.W))
            transform.position += t.forward * 2 * Time.deltaTime;
        if (Input.GetKey(KeyCode.S))
            transform.position += t.forward * -2 * Time.deltaTime;
        if (Input.GetKey(KeyCode.D))
            transform.position += t.right * 2 * Time.deltaTime;
        if (Input.GetKey(KeyCode.A))
            transform.position += t.right * -2 * Time.deltaTime;
    }
    public Transform t;
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
