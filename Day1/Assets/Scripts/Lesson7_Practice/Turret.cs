using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Turret : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float angle = Mathf.Sin(Time.time) * 50;//倾斜的角度会在30 ~ -30之间变化,因为正弦函数Sin(Time.time)会在-1 ~ 1之间变化
        transform.localRotation = Quaternion.Euler(0, angle, 0);
    }
}
