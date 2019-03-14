using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RevisedTimer : MonoBehaviour
{
    [SerializeField] private GameObject DefeatUI;
    [SerializeField] private bool isPaused;

    //public bool timesUp = false;
    public Text timeText;
    private float cur_time = 5;
    private float elapsedTime;

    void Start()
    {
    }

    private void Update()
    {
        while (cur_time - elapsedTime > 0) {
            timeText.text = ((cur_time - elapsedTime).ToString("TIME: 00"));
            elapsedTime += Time.deltaTime;
        }

        if (cur_time - elapsedTime <= 0)
        {
            DefeatMenu();
        }

        /*elapsedTime >= 99
        if (cur_time - elapsedTime <= (float)0)
        {
            isPaused = !isPaused;
        }

      
        */
    }

    void DefeatMenu()
    {
        Time.timeScale = 0;
        AudioListener.pause = true;
        DefeatUI.SetActive(true);
    }
}