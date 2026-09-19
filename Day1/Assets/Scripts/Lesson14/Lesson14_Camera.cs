using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lesson14_Camera : MonoBehaviour
{
    private void Watch()
    {
        transform.RotateAround(transform.position, Vector3.up, Input.GetAxis("Mouse X") * 1);
        transform.RotateAround(transform.position, transform.right, Input.GetAxis("Mouse Y") * -1);
    }
    public Transform capsule;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Watch();
        transform.position = new Vector3(capsule.transform.position.x, capsule.transform.position.y + 0.8f, capsule.transform.position.z);
        if (Input.GetMouseButtonUp(0)) 
        { 

        }
    }
}
