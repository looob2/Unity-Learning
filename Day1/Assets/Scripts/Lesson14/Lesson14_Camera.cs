using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lesson14_Camera : MonoBehaviour
{
    private void Watch()
    {
        transform.RotateAround(transform.position, Vector3.up, Input.GetAxis("Mouse X") * 1);
        transform.RotateAround(transform.position, Vector3.right, Input.GetAxis("Mouse Y") * -1);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Watch();
    }
}
