using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RevisedTimer : MonoBehaviour
{
    [SerializeField] private GameObject DefeatUI;

    public bool timesUp = false;
    public Text timeText;
    private float cur_time = 99;
    private float elapsedTime;

    void Start()
    {
        float elapsedTime = 0;
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;
        timeText.text = ((cur_time - elapsedTime).ToString("TIME: 00"));

        if (elapsedTime >= 99)
        {
            timesUp = true;
            DefeatUI.SetActive(true);
            elapsedTime = 0;
        }

    }
}