using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson3 : MonoBehaviour
{
    public GameObject gameObj;//准备克隆的对象

    // Start is called before the first frame update
    void Start()
    {
        print(gameObject.name);
        gameObject.name = "Lesson3_NewName";//改名和打印名字

        print(gameObject.activeSelf);//是否激活

        print(gameObject.isStatic);//是否静态

        print(gameObject.layer);//层级

        print(gameObject.tag);//标签

        print(this.gameObject.transform.position);//等价于this.transform.position

        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);//在场景中创建一个实体
        obj.name = "obj_Cube";

        GameObject obj2 = GameObject.Find("Lesson3");//通过对象名查找

        GameObject obj3 = GameObject.Instantiate(gameObj);//克隆一个对象

        GameObject.Destroy(obj3 , 5);//删除一个对象,后面的参数是延迟()秒删除

        GameObject.Destroy(this);//还可以删除脚本对象

        //GameObject.DestroyImmediate()可以立即删除对象,普通的Destroy只是在下一帧移除

        GameObject.DontDestroyOnLoad(this.gameObject);//自己依附的GameObject对象,过场景不被删除
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
