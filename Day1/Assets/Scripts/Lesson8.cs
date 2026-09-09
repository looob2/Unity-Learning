using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson8 : MonoBehaviour
{
    public GameObject tank;
    // Start is called before the first frame update
    void Start()
    {
        //打印缩放数据信息
        //print(transform.lossyScale);
        //print(transform.localScale);
        //修改物体的大小transform.localScale = new Vector(3, 3, 3);
        

    }

    // Update is called once per frame
    void Update()
    {
        //使物体随时间变大
        //transform.localScale += Vector3.one * Time.deltaTime;

        //看向一个点
        //transform.LookAt(Vector3.zero);

        transform.LookAt(tank.transform);
    }
}
