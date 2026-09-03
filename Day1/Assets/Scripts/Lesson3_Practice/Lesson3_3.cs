using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Myenum
{
    ChangeName,
    Enabled,
    Delete_Wait,
    Delete
}

public class Lesson3_3 : MonoBehaviour
{
    public Myenum option;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (option)
        {
            case 0:
                gameObject.name = "ÒÑÐÞ¸Ä";
                break;
        }
    }
}
