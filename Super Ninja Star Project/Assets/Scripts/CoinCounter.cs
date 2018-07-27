using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour {

    public Text Coins;

    private GameObject player;
    private Movement playerData;

    void Awake ()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerData = player.GetComponent<Movement>();
    }

    private void Update()
    {
        UpdateCoin(playerData.CoinsCollected);
    }

    void UpdateCoin(int numberOfCoins)
    {
        Coins.text = numberOfCoins.ToString() + "/50";
    }
}