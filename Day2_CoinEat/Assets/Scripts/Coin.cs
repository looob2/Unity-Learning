using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    private Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(transform.up * 0.5f);
        transform.position = startPos + new Vector3(0, 0.1f, 0) * Mathf.Sin(Mathf.PI * Time.time);
    }
}
