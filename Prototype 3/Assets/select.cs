using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;



public class select : MonoBehaviour
{










    public void ButtonClick()
    {


        if (EventSystem.current.currentSelectedGameObject.name == "sphere") // CODE FOR "SELECT" BUTTON

        {
            SceneManager.LoadScene("Tutorial_sphere");

        }





        if (EventSystem.current.currentSelectedGameObject.name == "cube") // CODE FOR "SELECT" BUTTON

        {
            SceneManager.LoadScene("Tutorial_cube");

        }


    }


}
