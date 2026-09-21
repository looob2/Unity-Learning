using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson14_Bullet : MonoBehaviour
{
    private float speed = 20;
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
