﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudManager : MonoBehaviour
{
    [SerializeField]
    private Text killCounter;
    private int killsAmount = 0;

    void Start()
    {
        FindObjectOfType<ClickHandler>().enemyKilledEvent += UpdateCounter;
    }

    void UpdateCounter()
    {
        killsAmount++;
        killCounter.text = "Kills: " + killsAmount.ToString();
    }
}
