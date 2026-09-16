using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson12 : MonoBehaviour
{
    public Transform tank;
    // Start is called before the first frame update
    void Start()
    {
        //获取主摄像机
        print(Camera.main.name);
        //获取摄像机的数量
        print(Camera.allCamerasCount);
        //得到所有摄像机
        Camera[] Cameras = Camera.allCameras;

        //界面上的参数,都可以通过Camera.获得,比如Camera.main.depth

        //世界坐标转屏幕坐标,z轴代表的是离摄像机有多远
        Vector3 v = Camera.main.WorldToScreenPoint(tank.position);
        print(v);
    }

    // Update is called once per frame
    void Update()
    {
        //屏幕坐标转世界坐标
        //Vector3 v1 = Input.mousePosition;
        //v1.z = 10;
        //print(v1);

        if (Input.GetMouseButtonUp(0))
        {
            Vector3 v2 = Input.mousePosition;
            v2.z = 10;
            Vector3 v3 = Camera.main.ScreenToWorldPoint(v2);
            GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
            obj.transform.position = v3;           
        }
    }
}
