﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    public Rigidbody rg;

    public int sidewaysForce = 700;
    public int forwardForce = 720;
    public int upwardForce = 3000;

    // Update is called once per frame
    void FixedUpdate()
    {
        rg.AddForce(forwardForce * Time.deltaTime, 0, 0);

        if (Input.GetKey("a"))
        {
            rg.AddForce(0, 0, sidewaysForce * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            rg.AddForce(0, 0, -sidewaysForce * Time.deltaTime);
        }

        if (Input.GetKey("space"))
        {
            rg.AddForce(0, upwardForce * Time.deltaTime, 0);
        }
    }
}