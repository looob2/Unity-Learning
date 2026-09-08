using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson7 : MonoBehaviour
{
    public GameObject obj;
    private GameObject tank;
    // Start is called before the first frame update
    void Start()
    {
        tank = Instantiate(obj);
        tank.transform.position = new Vector3(gameObject.transform.position.x + 2.7f, gameObject.transform.position.y + 2.5f, gameObject.transform.position.z - 2);
    }

    // Update is called once per frame
    void Update()
    {
        tank.transform.RotateAround(transform.position, transform.up , 5 * Time.deltaTime);//坦克围绕展台的Y轴旋转
                                
    }
}
