using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lesson1 : MonoBehaviour
{
    //public Rect labRect;
    //public GUIContent labContent;
    //public GUIStyle labStyle;
    public Rect btnRect;
    public GUIContent btnContent;
    public GUIStyle btnStyle;

    private Texture2D _bgTex;

    private void OnGUI()
    {
        if (_bgTex == null)
        {
            _bgTex = new Texture2D(1, 1);
            _bgTex.SetPixel(0, 0, new Color(0.25f, 0.25f, 0.25f, 1f)); // Éî»ÒÉ«
            _bgTex.Apply();
        }

        //GUI.Label(labRect, labContent, labStyle);

        if (btnStyle == null)
        {
            btnStyle = new GUIStyle(GUI.skin.button);
            btnStyle.fontSize = 30;
            btnStyle.normal.background = _bgTex;
            btnStyle.hover.background = _bgTex;
            btnStyle.active.background = _bgTex;
            btnStyle.normal.textColor = Color.white;
            btnStyle.hover.textColor = Color.yellow;
            btnStyle.active.textColor = Color.gray;

        }

        if (GUI.Button(btnRect, btnContent, btnStyle))
        {

        }
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
