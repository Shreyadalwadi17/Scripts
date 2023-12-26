using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float value = 0;
    private float hour;
    private float minutes;
    private float sec;
    private float miliSec;
    public TMP_Text display;


    // private void Start()
    // {
    //     hour = (int)value / 60;
    //     minutes = hour * 60;
    //     sec = minutes * 60;
    //     miliSec = sec * 1000;

    //     hourtxt.text = hour.ToString();
    //     minutestxt.text = minutes.ToString();
    //     sectxt.text = sec.ToString();
    //     miliSectxt.text = miliSec.ToString();

    // }
    //public  void PlayTimer()
    // {
    //     value -= Time.deltaTime;
    // }
    private void Start()
    {
        Time.timeScale = 1;
    }

    private void Update()
    {
        value -= Time.deltaTime;
        DisplayTimer(value);
    }

    public void DisplayTimer(float value)
    {
        float hour = Mathf.FloorToInt(value / 3600);
        float minutes = Mathf.FloorToInt((value - 3600 * hour) / 60);
        float sec = Mathf.FloorToInt(value % 60);
        float miliSec = Mathf.FloorToInt(value * 3600);

        display.text = string.Format("{0:00}:{1:00}:{2:00}:{3:00}", hour, minutes, sec, miliSec);
    }

    public void PauseTimer()
    {
        Time.timeScale = 0;
    }
    public void PlayTimer()
    {
        Time.timeScale = 1;
    }
    //public void AddMin()
    //{
    //    minutes = +5;
    //}
    //public void AddSec()
    //{
    //    sec = +10;
    //}


}
