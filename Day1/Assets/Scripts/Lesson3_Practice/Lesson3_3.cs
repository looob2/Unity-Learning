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
        switch ((int)option)
        {
            case 0:
                gameObject.name = "ÒÑÐÞ¸Ä";
                break;
            case 1:
                gameObject.SetActive(false);
                break;
            case 2:
                GameObject.Destroy(gameObject , 2);
                break;
            case 3:
                GameObject.DestroyImmediate(gameObject);
                break;
        }
    }
}
