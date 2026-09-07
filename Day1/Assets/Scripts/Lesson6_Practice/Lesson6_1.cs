using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson6_1 : MonoBehaviour
{
    public GameObject tank;
    private GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        obj = Instantiate(tank);
    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.Translate(transform.forward * 1 * Time.deltaTime, Space.World);
    }
}
