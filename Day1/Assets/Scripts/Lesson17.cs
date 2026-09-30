using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson17 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * 2 * Time.deltaTime;
        transform.position += transform.right * Mathf.Sin(Time.time) * 2 * Time.deltaTime;
    }
}
