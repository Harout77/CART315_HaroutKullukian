﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{


    [Header("Ball")]
    public GameObject ball;

    [Header("Player 1")]
    public GameObject player1Paddle;
    public GameObject player1Goal;


    [Header("Player 2")]
    public GameObject player2Paddle;
    public GameObject player2Goal;

    [Header("Score UI")]
    public GameObject player1Text;
    public GameObject player2Text;

    private int player1Score;
    private int player2Score;

    public void player1Scored()

    {
        player1Score++;
        player1Text.GetComponent<TMPro.TextMeshProUGUI>().text = player1Score.ToString();
        ResetPosition();

    }

    public void player2Scored()

    {
        player2Score++;
        player2Text.GetComponent<TMPro.TextMeshProUGUI>().text = player2Score.ToString();
        ResetPosition();

    }


    private void ResetPosition()
    {
        ball.GetComponent<ball>().Reset();
        player1Paddle.GetComponent<paddle>().Reset();
        player2Paddle.GetComponent<paddle>().Reset();

    }

}
