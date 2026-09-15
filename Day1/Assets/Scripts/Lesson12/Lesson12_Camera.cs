using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson12_Camera : MonoBehaviour
{
    public Transform tank;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(tank.position.x, transform.position.y , tank.position.z);
    }
}
