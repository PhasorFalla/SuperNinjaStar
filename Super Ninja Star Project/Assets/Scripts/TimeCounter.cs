using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour {

    public float TimeCount;
    public Text Timer;
    public Text Timer2;

	
	void Update () {
        TimeCount += Time.deltaTime *2;

        float minutes = Mathf.Floor(TimeCount / 60);
        float miliseconds = (Mathf.Round(TimeCount * 100) / 100);

        Timer.text = minutes.ToString() + "." + miliseconds;
        Timer2.text = minutes.ToString() + "." + miliseconds;

    }
}
