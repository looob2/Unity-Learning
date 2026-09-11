using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson9_Practice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.NameSort();
        transform.FindPro("GameObject");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public static class Toll
{
    public static void NameSort(this Transform t)
    {
        for (int i = 0; i < t.childCount - 1; i++)
        {
            for (int j = 0; j < t.childCount - i - 1; j++)
            {
                if(t.GetChild(j).name.Length > t.GetChild(j + 1).name.Length)
                    t.GetChild(j).SetSiblingIndex(j + 1);//因为GetChild的思路类似于插入,所以不用考虑j和j+1之间的先后
            }
        }
    }

    public static void FindPro(this Transform t, string gameObjectName)
    {
        if (t.Find(gameObjectName).name != null)
            Debug.Log("子类中的" + t.Find(gameObjectName).name);

        for (int i = 0; i < t.childCount; i++)
        {
            if (t.GetChild(i).Find(gameObjectName) != null)
            {
                Debug.Log("子类的子类中的" + t.GetChild(i).Find(gameObjectName).name);
            }
        }
    }
}

