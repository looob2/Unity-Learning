using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MyEnum
{
    player,
    monster,
    boss
}



public class Lesson1 : MonoBehaviour
{
    [SerializeField]//使private和protected可以显示
    private int privateInt;
    [SerializeField]
    protected string protectedStr;

    public int publicInt = 10;
    public bool publicBool = false;

    [HideInInspector]//使公共的无法显示
    public int publicInt2;

    public int[] array;
    public List<int> list;
    public MyEnum type;
    public GameObject gameobj;



    ["战斗属性"]
    public int atk;

    [Range(0 , 10)]
    public float luck;

    [ContextMenuItem("重置钱", "Test")]
    public int money;
    private void Test()
    {
        money = 99;
    }

    private void Start() 
    {
        print(privateInt);
        print(protectedStr);
    }
}
