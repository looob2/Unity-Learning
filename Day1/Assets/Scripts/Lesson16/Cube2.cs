using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube2 : MonoBehaviour
{
    public Transform cube;
    private Vector3 start;
    private Vector3 end;
    private Vector3 result;
    private float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        start = transform.position;
        end = cube.position;
        if (time >= 1)
        {
            time = 0;
        }
        time += Time.deltaTime;
        result.x = Mathf.Lerp(start.x, end.x, time);
        result.y = Mathf.Lerp(start.y, end.y, time);
        result.z = Mathf.Lerp(start.z, end.z, time);
        transform.position = result;
    }
}
