using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathCounter : MonoBehaviour {

    private Text DeathText;

    private void Start()
    {
        DeathText = GetComponent<Text>();
    }

    void Update ()
    {
        DeathText.text = FanReset.deathzone.deaths.ToString();
   	}
}