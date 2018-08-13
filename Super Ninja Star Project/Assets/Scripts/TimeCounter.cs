﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour {

    public float TimeCount;
    public Text Timer;
    public Text Timer2;

	
	void Update () {
        TimeCount += Time.deltaTime;

        float minutes = Mathf.Floor(TimeCount / 60);
        string seconds = (TimeCount % 60).ToString("f2");

        Timer.text = minutes.ToString() + "." + seconds;
        Timer2.text = minutes.ToString() + "." + seconds;

    }
}
