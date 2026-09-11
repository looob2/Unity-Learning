using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Lesson10_Practice : MonoBehaviour
{
    public void CreateEmpty()
    {
        GameObject empty = new GameObject();
        empty.transform.position = transform.TransformPoint(new Vector3(-1, 0, 1));
    }
    public void CreatBall()
    {
        GameObject ball1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        GameObject ball2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        GameObject ball3 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        ball1.transform.position = transform.TransformPoint(new Vector3(0, 0, 1));
        ball2.transform.position = transform.TransformPoint(new Vector3(0, 0, 2));
        ball3.transform.position = transform.TransformPoint(new Vector3(0, 0, 3));

    }
    // Start is called before the first frame update
    void Start()
    {
        CreateEmpty();
        CreatBall();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
