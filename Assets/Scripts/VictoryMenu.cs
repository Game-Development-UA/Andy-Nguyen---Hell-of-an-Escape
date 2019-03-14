using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VictoryMenu : MonoBehaviour
{
    public GameObject VictoryUI;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Time.timeScale = 0;
            AudioListener.pause = true;
            VictoryUI.SetActive(true);
        }

    }
}
