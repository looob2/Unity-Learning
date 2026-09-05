using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //时间静止
        Time.timeScale = 0;
        //时间正常
        Time.timeScale = 1;
        //时间二倍速
        Time.timeScale = 2;

        //帧间隔时间(最近的一帧用了多长时间)
        //受Scale影响
        print(Time.deltaTime);
        //不受Scale影响
        print(Time.unscaledDeltaTime);

        //游戏开始到现在的时间
        print(Time.time);//受Scale影响
        print(Time.unscaledTime);//不受Scale影响

        //从开始到现在游戏跑了多少帧
        print(Time.frameCount);
    }

    //物理帧间隔时间(在设置中的Time设置)
    private void FixedUpdate()
    {
        //受Scale影响
        print(Time.fixedDeltaTime);
        //不受Scale影响
        print(Time.fixedUnscaledDeltaTime);
    }
}
