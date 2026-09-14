using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson11_UpDown : MonoBehaviour
{
    public Transform turret;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(turret.position, Vector3.right, Input.mouseScrollDelta.y * 360 * Time.deltaTime);
    }
}
