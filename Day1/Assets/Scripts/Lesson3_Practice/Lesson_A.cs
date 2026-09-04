using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson_A : MonoBehaviour
{
    public GameObject tank;
    public GameObject B;
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = GameObject.Instantiate(tank);
        Lesson_B b = GameObject.FindObjectOfType<Lesson_B>();
        b.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
