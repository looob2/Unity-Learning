using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube1 : MonoBehaviour
{
    private Vector3 start;
    private Vector3 end;
    public Transform cube;
    // Start is called before the first frame update
    void Start()
    {
        start = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        end = cube.transform.position;
        start.x = Mathf.Lerp(start.x, end.x, Time.deltaTime);
        start.y = Mathf.Lerp(start.y, end.y, Time.deltaTime);
        start.z = Mathf.Lerp(start.z, end.z, Time.deltaTime);
        transform.position = start;
    }
}
