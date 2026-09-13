using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson11 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //屏幕坐标的原点在屏幕左下角,且只有X和Y轴
        //print(Input.mousePosition);

        //检测鼠标(0是左键,1是右键,2是中键)
        //检测鼠标按下
        if (Input.GetMouseButtonDown(0))
            print("左键按下");
        //检测鼠标抬起
        if (Input.GetMouseButtonUp(0))
            print("左键抬起");
        //检测鼠标长按按下抬起都会进入
        if (Input.GetMouseButton(0))
            print("左键按下");
        //检测中键 Y值为-1是向下,0是不动,1是向上
        //print(Input.mouseScrollDelta);

        //检测键盘
        //按下键盘
        if (Input.GetKeyDown(KeyCode.W))
            print("按下W键");
        //传入字符串的重载(只能写小写,但是大小写都可以检测到)
        if (Input.GetKeyDown("q"))
            print("按下Q键");
        //抬起键盘
        if (Input.GetKeyUp(KeyCode.W))
            print("抬起W键");
        //长按键盘
        if (Input.GetKey(KeyCode.W))
            print("长按W键");

        //默认轴输入(可以去Edit的Project Settings的Input Manager里找)
        //键盘AD按下时,返回-1到1之间的变换
        print(Input.GetAxis("Horizontal"));//水平移动
        //键盘SW按下时,返回-1到1之间的变换
        print(Input.GetAxis("Vertical"));
        //鼠标横向移动时
        print(Input.GetAxis("Mouse X"));
        //鼠标竖向移动时
        print(Input.GetAxis("Mouse Y"));
        //GetAxisRaw方法和GetAxis方法使用方法相同,只不过只会在-1,1,0三值中变化
    }
}
