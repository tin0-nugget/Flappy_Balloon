using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Life_Code : MonoBehaviour
{
    private Text life;
    protected static int life_amt;

    void Start()
    {
        life_amt = 3;
        life = GetComponent<Text>();
        life.text = "LIFE: " + life_amt;
    }

    private void Update()
    {
        life.text = "LIFE: " + life_amt;

        if (life_amt == 0)
        {
            SceneManager.LoadScene("Game_Lost_Screen");
        }
    }
    public static void ReduceLife()
    {
        life_amt = life_amt - 1;
    }
}