using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class theEnd : MonoBehaviour
{


    public gameManager gameManager;




    private void OnTriggerEnter()
    {

        gameManager.levelComplete();

    }











}
