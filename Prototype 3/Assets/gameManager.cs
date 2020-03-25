using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{

    bool EndGame = false;
    public float restartDelay = 2f;


    public GameObject levelCompleteUI;







    public void levelComplete ()

    {

        levelCompleteUI.SetActive(true);
    }
    public void GameOver()

    {
        if (EndGame ==false)

        {
            EndGame = true;
            Debug.Log("GameOver");
            Invoke("Restart", restartDelay);

        }



    }



    void Restart ()

    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }




}
