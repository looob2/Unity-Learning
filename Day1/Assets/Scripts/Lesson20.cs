using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lesson20 : MonoBehaviour
{
    public Transform cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //float resultDot = Vector3.Dot(transform.forward, (cube.position - transform.position).normalized);
        //Vector3 resultCross = Vector3.Cross(transform.forward, cube.position - transform.position);
        //if (resultDot >= 0 && resultCross.y >= 0)
        //    print("他在我右前方");
        //else if (resultDot >= 0 && resultCross.y < 0)
        //    print("他在我左前方");
        //else if (resultDot < 0 && resultCross.y >= 0)
        //    print("他在我右后方");
        //else if (resultDot < 0 && resultCross.y < 0)
        //    print("他在我左后方");

        Vector3 resultCross = Vector3.Cross(transform.forward, cube.position - transform.position);
        float resultDot = Vector3.Dot(transform.forward, (cube.position - transform.position).normalized);
        float angle = Mathf.Acos(resultDot) * Mathf.Rad2Deg;
        float distance = Vector3.Distance(transform.position, cube.position);
        if (resultCross.y >= 0 && angle <= 30 && distance <= 5)
            print(angle + "发现入侵者" + distance);
        else if (resultCross.y < 0 && angle <= 20 && distance <= 5)
            print(angle + "发现入侵者" + distance);        
    }
}
