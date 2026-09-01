using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(this.gameObject.name);//打印实体信息
        print(this.transform.position);//位置信息
        print(this.transform.eulerAngles);//角度
        print(this.transform.lossyScale);//缩放大小

        //通过脚本名获取
        Lesson2_Test t = this.GetComponent("Lesson2_Test") as Lesson2_Test;//获取其他挂在同一实体上的脚本的值
        print(t.name);

        //通过type获取
        t = this.GetComponent(typeof(Lesson2_Test)) as Lesson2_Test;

        //通过泛型获取
        t = this.GetComponent<Lesson2_Test>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
