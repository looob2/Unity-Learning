using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lesson14_Camera : MonoBehaviour
{
    private float xRotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xRotation -= Input.GetAxis("Mouse Y") * 2;
        
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

        if (Input.GetMouseButtonUp(0)) 
        { 
            GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            Vector3 v = Input.mousePosition;
            v.z = 2;
            obj.transform.position = Camera.main.ScreenToWorldPoint(v);
        }
    }
}
