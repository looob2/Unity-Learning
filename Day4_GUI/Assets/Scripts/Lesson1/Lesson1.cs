using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson1 : MonoBehaviour
{
    public Rect labRect;
    public GUIContent labContent;
    public GUIStyle labStyle;
    public Rect btnRect;
    public GUIContent btnContent;
    public GUIStyle btnStyle;
    private void OnGUI()
    {
        GUI.Label(labRect, labContent, labStyle);

        GUI.Button(btnRect, btnContent, btnStyle);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
