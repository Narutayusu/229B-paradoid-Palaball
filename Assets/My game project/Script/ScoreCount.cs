using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    public Transform player;
    public TMP_Text scoretext;

    private void Update()
    {
        scoretext.text = player.position.z.ToString("0.0")+"m";
    }
}



