﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup : MonoBehaviour
{

    public float multiplier = 0;

    public GameObject pickupEffect;

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))


        {
            Pickup(other);
        }



    }



    void Pickup(Collider player)

    {

        Instantiate(pickupEffect, transform.position, transform.rotation);

        player.transform.localScale *= multiplier;

        Destroy(gameObject);

    }


}
