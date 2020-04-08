using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class gameManager : MonoBehaviour
{

    bool EndGame = false;
    public float restartDelay = 2f;










    public Text canvasText1;
    void Start()
    {
        Invoke("DisableText", 3f);//invoke after 3 seconds
    }
    void DisableText()
    {
        canvasText1.enabled = false;
    }

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

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }




}
