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
        moon.transform.SetParent(earth.transform);
        earth.transform.position = new Vector3(transform.position.x + 6, transform.position.y, transform.position.z);
        moon.transform.localPosition = new Vector3(2, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Vector3.Distance(earth.transform.position, moon.transform.position));
        
        earth.transform.RotateAround(transform.position, transform.up, 4 * Time.deltaTime);

        moon.transform.RotateAround(earth.transform.position, Vector3.up, 40 * Time.deltaTime);
    }
}
