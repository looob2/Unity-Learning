using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson14_Shoot : MonoBehaviour
{
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Transform cam = Camera.main.transform;
            Vector3 camPosition = cam.position;
            camPosition.z += 1;
            GameObject.Instantiate(bullet, camPosition, cam.rotation);
        }
    }
}
