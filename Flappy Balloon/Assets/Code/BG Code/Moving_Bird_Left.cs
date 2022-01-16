using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Moving_Bird_Left : MonoBehaviour
{
    private GameObject player;
    private float starting_position_x;
    private bool left = true;

    void Start()
    {
        starting_position_x = transform.position.x;
        player = GameObject.Find("Player_Balloon");
    }

    void Update()
    {
        if (left)
        {
            transform.Translate(-100 * Time.deltaTime, 0, 0);

            if (transform.position.x < -starting_position_x)
            {
                transform.Rotate(0, 180, 0);
                left = false;
            }
        }
        else if (!left)
        {

            transform.Translate(-100 * Time.deltaTime, 0, 0);

            if (transform.position.x > starting_position_x)
            {
                transform.Rotate(0, -180, 0);
                left = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        try
        {
            player.transform.position = new Vector2(0, 3);
            UI_Life_Code.ReduceLife();
        }
        catch
        {
            Debug.Log("Error");
        }
    }
}
