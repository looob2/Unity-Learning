using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(Vector3.forward);
        //世界坐标系的点转换为本地的(受缩放影响)
        print(transform.InverseTransformPoint(Vector3.forward));
        //世界坐标系的房向转换为本地的
        //不受缩放影响的
        print(transform.InverseTransformDirection(Vector3.forward));
        //受缩放影响的
        print(transform.InverseTransformVector(Vector3.forward));

        //本地坐标系转世界坐标系
        //本地坐标系点转换为世界的
        print(transform.TransformPoint(Vector3.forward));
        //本地坐标系方向转换为世界的
        //受缩放影响
        print(transform.TransformDirection(Vector3.forward));
        //不受缩放影响
        print(transform.TransformVector(Vector3.forward));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
