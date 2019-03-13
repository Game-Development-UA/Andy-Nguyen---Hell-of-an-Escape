using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float cur_time = 99;
    public Text timeText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeText.text = ((cur_time - Time.time).ToString());
        ///if (time < 0)
        {
            ///GameOver();
        }
    }
}
