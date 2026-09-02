using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A : MonoBehaviour
{
    public GameObject bObject;//先定义一个B对象的引用,再在外面将B对象拖入

    // Start is called before the first frame update
    void Start()
    {
        B b = bObject.GetComponent<B>();//通过B对象得到B对象GameObject上面挂着的B脚本
        b.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
