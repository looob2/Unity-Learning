using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //申明新坐标
        Vector3 v = new Vector3(10, 10, 10);
        Vector3 v2 = new Vector3(12, 12, 12);

        print(Vector3.zero);//原点坐标000
        print(Vector3.right);//100朝右(X轴)
        print(Vector3.left);//-100
        print(Vector3.forward);//001朝前(Z轴)
        print(Vector3.back);//00-1
        print(Vector3.up);//010朝上(Y轴)
        print(Vector3.down);//0-10

        //计算两个坐标之间的距离
        Vector3.Distance(v, v2);

        //当前对象的相对世界坐标位置
        print(transform.position);

        //相对父对象(面板坐标)
        print(transform.localPosition);

        //位置的坐标不能单独修改,比如:transform.position.x = 10
        transform.position = new Vector3(1, 1, 1);

        //若想单独修改:
        transform.position = new Vector3(transform.position.x, 12, transform.position.y);
        //或是
        Vector3 vp = transform.position;
        vp.x = 21;
        transform.position = vp;

        //对象当前的各朝向
        print(transform.forward);//面朝向
        print(transform.right);//右朝向
        print(transform.up);//上朝向
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
