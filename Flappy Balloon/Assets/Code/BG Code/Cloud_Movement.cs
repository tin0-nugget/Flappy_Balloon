using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud_Movement : MonoBehaviour
{

    float startX;
    bool left = true;

    // Start is called before the first frame update
    void Start()
    {
        startX = transform.position.x + 500;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "cloud_group_2")
        {
            if (left)
            {
                transform.Translate(0.01f, 0, 0);

                if (transform.position.x < -startX)
                {
                    transform.Rotate(0, 180, 0);
                    left = false;
                }
            }
            else if (!left)
            {

                transform.Translate(0.01f, 0, 0);

                if (transform.position.x > startX)
                {
                    transform.Rotate(0, -180, 0);
                    left = true;
                }
            }
        }
        else
        {

            if (left)
            {
                transform.Translate(-0.01f, 0, 0);

                if (transform.position.x < -startX)
                {
                    transform.Rotate(0, 180, 0);
                    left = false;
                }
            }
            else if (!left)
            {

                transform.Translate(-0.01f, 0, 0);

                if (transform.position.x > startX)
                {
                    transform.Rotate(0, -180, 0);
                    left = true;
                }
            }
        }
    }
}

