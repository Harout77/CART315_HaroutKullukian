using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{

    public movement Movement;
   void OnCollisionEnter(Collision collisionInfo)

    {
        

          if (collisionInfo.collider.tag =="obstacle")
        {

            Movement.enabled = false;
            FindObjectOfType<gameManager>().GameOver();

        }

    }




}
