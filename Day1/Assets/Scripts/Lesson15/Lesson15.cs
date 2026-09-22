using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson15 : MonoBehaviour
{
    Rigidbody body;
    // Start is called before the first frame update
    void Start()
    {
        //获取刚体组件
        body = GetComponent<Rigidbody>();

        //施加力
        //相对世界坐标
        body.AddForce(Vector3.forward * 10);
        //相对本地坐标
        body.AddForce(transform.forward * 10);
        body.AddRelativeForce(transform.forward * 10);

        //添加扭矩力
        //相对世界坐标
        body.AddTorque(Vector3.up * 10);
        //相抵本地坐标
        body.AddTorque(transform.up * 10);
        body.AddRelativeTorque(Vector3.up * 10);

        //直接改变速度
        body.velocity = Vector3.forward * 10;

        //在某点添加一个爆炸
        //(力的大小, 爆炸中心点, 爆炸范围)
        body.AddExplosionForce(100, Vector3.zero, 10);

        //力的几种模式

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
