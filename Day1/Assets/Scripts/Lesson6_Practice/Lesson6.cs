using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //当前位置 + 要动多少距离(方向*速度*时间) = 最终距离
        transform.position = transform.position + transform.forward * 1 * Time.deltaTime;

        //第一个参数:表示位移
        //第二个参数:表示相对坐标系 不填默认是相对自己的坐标系

        //相对于世界坐标系的z轴移动
        transform.Translate(Vector3.forward * 1 * Time.deltaTime , Space.World);//(世界坐标系)

        //相对于世界坐标系的自己的z轴移动
        transform.Translate(transform.forward * 1 * Time.deltaTime, Space.World);

        //按自己的z轴的自己坐标系下的方向移动(以自己的坐标系为参考系解释在世界坐标系下自己面朝的方向)
        transform.Translate(transform.forward * 1 * Time.deltaTime, Space.Self);
    }
}
