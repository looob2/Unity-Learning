using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson14_Hp : MonoBehaviour
{
    private int hp = 3;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
            hp--;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hp == 0)
            Destroy(gameObject);
    }
}
