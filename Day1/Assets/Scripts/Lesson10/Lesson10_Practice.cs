using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Lesson10_Practice : MonoBehaviour
{
    public void CreateEmpty()
    {
        GameObject empty = new GameObject();
        Vector3 point = transform.TransformPoint(gameObject.transform.forward);
        empty.transform.position = new Vector3(point.x - 1, point.y, point.z + 1);
    }
    public void CreatBall()
    {
        GameObject ball1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        GameObject ball2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        GameObject ball3 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        Vector3 point = transform.TransformPoint(gameObject.transform.forward);
        ball1.transform.position = point;
        ball2.transform.position = new Vector3(point.x, point.y, point.z + 1);
        ball3.transform.position = new Vector3(point.x, point.y, point.z + 2);

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
