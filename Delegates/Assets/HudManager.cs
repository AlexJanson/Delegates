using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudManager : MonoBehaviour
{
    [SerializeField]
    private Text killCounter;

    private int killsAmount = 0;

    private delegate void ScoreDelegate(GameObject player);

    private GameObject playerObj;

    void Start()
    {
        playerObj = GameObject.Find("Player");
    }

    int GetPlayerKills(GameObject _player)
    {
        return playerObj.killsAmount;
    }

    void UpdateCounter()
    {
        int _playerKills = 

        killCounter.text = "Kills: " + killsAmount.ToString();
    }
}
