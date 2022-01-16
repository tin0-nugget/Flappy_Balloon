using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Collision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        UI_Score_Code.AddPointToScore();
        Destroy(gameObject);
    }
}
