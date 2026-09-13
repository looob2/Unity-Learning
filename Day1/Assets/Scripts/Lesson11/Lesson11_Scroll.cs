using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lesson11_Scroll : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(Input.GetAxis("Mouse X"));
        transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0) * 3);
    }
}
