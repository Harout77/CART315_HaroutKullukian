using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour
{

    public bool isplayer1Goal;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            if(!isplayer1Goal)
            {
                Debug.Log("Player 1 Scored...");
                GameObject.Find("gamemanager").GetComponent<gamemanager>().player1Scored();
            }
            else
            {
                Debug.Log("Player 2 Scored...");
                GameObject.Find("gamemanager").GetComponent<gamemanager>().player2Scored();
            }
        }
    }





}
