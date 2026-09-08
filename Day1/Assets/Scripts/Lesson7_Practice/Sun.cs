using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    private GameObject earth;
    private GameObject moon;
    // Start is called before the first frame update
    void Start()
    {
        earth = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        moon = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        earth.transform.position = new Vector3(transform.position.x + 7, transform.position.y, transform.position.z);
        moon.transform.position = new Vector3(earth.transform.position.x + 2, earth.transform.position.y, earth.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        moon.transform.RotateAround(earth.transform.position, earth.transform.up, 40 * Time.deltaTime);
        earth.transform.RotateAround(transform.position, transform.up, 4 * Time.deltaTime);
    }
}
