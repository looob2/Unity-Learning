using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson19 : MonoBehaviour
{
    public Transform cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float resultDot = Vector3.Dot(transform.forward, (cube.position - transform.position).normalized);
        float angle = Mathf.Acos(resultDot) * Mathf.Rad2Deg;
        float distance = (cube.position - transform.position).magnitude;
        if (angle <= 22.5f && distance <= 5)        
            print("发现入侵者");
        
    }
}
