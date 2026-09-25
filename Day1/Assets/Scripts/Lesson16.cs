using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson16 : MonoBehaviour
{
    private float start;
    // Start is called before the first frame update
    void Start()
    {
        print(Mathf.PI);
        //取绝对值
        print(Mathf.Abs(-10));
        //向上取整
        print(Mathf.CeilToInt(1.0001f));// = 2
        //向下取整
        print(Mathf.FloorToInt(9.9f));// = 9
        //钳制函数
        print(Mathf.Clamp(10, 11, 20));//(想要进行计算的值, 最小值, 最大值) 比最小的小取最小,比最大的大取最大,在中间取自己
        //获取最大值
        print(Mathf.Max(1, 2, 3, 4));
        //获取最小值
        print(Mathf.Min(1, 2, 3, 4));
        //一个数的n次幂
        print(Mathf.Pow(2, 3));//(数字, 次方)
        //四舍五入
        print(Mathf.RoundToInt(1.3f));
        //返回一个数的平方根
        print(Mathf.Sqrt(4));
        //判断一个数是否为2的n次方
        Mathf.IsPowerOfTwo(4);//bool类型
        //判断正负数
        Mathf.Sign(10);//返回值为float类型,正数为1,负数为-1
    }

    // Update is called once per frame
    void Update()
    {
        //插值运算 Lerp
        //result = Mathf.Lerp(start, end, t)
        //result = start + (end - start) * t
        start = Mathf.Lerp(start, 10, Time.deltaTime);
    }
}
