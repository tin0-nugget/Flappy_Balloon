using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon_Movement : MonoBehaviour
{
    private Rigidbody2D rigid;
    private float Jump_Force = 35500; 

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            rigid.AddForce(Vector2.up * Jump_Force);
        }
    }
}
