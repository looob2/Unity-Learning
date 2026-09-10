using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson9 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //获取父对象
        //print(transform.parent.name);

        //断开父对象与子对象关系
        //transform.parent = null;
        
        //设定父对象
        //transform.parent = GameObject.Find("Father2").transform;

        //设定父对象的API
        //第一个参数:父对象的transform信息
        //第二个参数:是否保留子对象在世界坐标中的位置
        transform.SetParent(GameObject.Find("Father2").transform, true);

        //断开自己所有子对象的关系
        //transform.DetachChildren();

        //获取子对象(失活的也可以找到)
        print(transform.Find("Cube").name);

        //遍历子对象
        print(transform.childCount);//子对象的数量
        for (int i = 0; i < transform.childCount; i++)
        {
            print(transform.GetChild(i).name);//通过索引器可以得到多个子对象中的某个
        }

        //判断自己是不是谁的子对象
        if (transform.IsChildOf(GameObject.Find("Father2").transform))
            print("是" + GameObject.Find("Father2").name + "的子对象");

        //得到自己在子对象中的编号
        print(transform.GetSiblingIndex());

        //将自己设定为子对象中的第一
        transform.SetAsFirstSibling();

        //将自己设定为子对象中的最后一个
        transform.SetAsLastSibling();

        //将自己设定为子对象中某一个(超出范围会自动设定为最后一个)
        transform.SetSiblingIndex(-1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
