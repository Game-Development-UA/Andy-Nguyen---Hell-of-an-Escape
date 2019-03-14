using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VictoryMenu : MonoBehaviour
{
    public GameObject VictoryUI;
    private bool GoalReached = false;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            GoalReached = true;
        }

    }
    void VictoryScreen()
    {
        VictoryUI.SetActive(true);
        Time.timeScale = 0;
        AudioListener.pause = true;
    }

    void Update()
    {
        if (GoalReached == true)
        {
            VictoryScreen();
        }

    }
}
