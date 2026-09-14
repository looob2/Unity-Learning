using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson11_Camera : MonoBehaviour
{
    public Transform tank;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(tank.position);
        if (Input.GetMouseButton(1))
            transform.RotateAround(tank.position, Vector3.up, Input.GetAxis("Mouse X") * 360 * Time.deltaTime);
    }
}
