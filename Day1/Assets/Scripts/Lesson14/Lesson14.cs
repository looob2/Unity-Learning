using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson14 : MonoBehaviour
{
    //碰撞刚开始时
    //private void OnCollisionEnter(Collision collision)
    //{
    //    //可以获得碰撞到的对象的碰撞器的信息
    //    //collision.collider;

    //    //可以获得碰撞对象的依附对象
    //    //collision.gameObject

    //    //可以获得碰撞对象的位置信息
    //    //collision.transform

    //    //得到碰撞点数
    //    //collsion.contactCount
    //    //接触点具体的坐标
    //    //ContactPoint[] points = collision.contacts

    //    print(name + "被" + collision.gameObject.name + "碰到了");
    //}

    ////碰撞结束
    //private void OnCollisionExit(Collision collision)
    //{
    //    print(name + "和" + collision.gameObject.name + "分开了");
    //}

    ////接触状态
    //private void OnCollisionStay(Collision collision)
    //{
    //    print(name + "和" + collision.gameObject.name + "在接触");
    //}

    ////检测碰撞刚开始
    //private void OnTriggerEnter(Collider other)
    //{
    //    print(name + "检测到" + other.gameObject.name + "碰到了");
    //}

    //private void OnTriggerExit(Collider other)
    //{
    //    print(name + "检测到" + other.gameObject.name + "分开了");
    //}

    //private void OnTriggerStay(Collider other)
    //{
    //    print(name + "检测到" + other.gameObject.name + "在重叠");
    //}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(transform.up * Input.GetAxis("Mouse X") * 2);
    }
}
