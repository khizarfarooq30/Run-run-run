using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceFollowPlayer : MonoBehaviour
{
    private PlayerMotor playerMotor;

    private void Awake()
    {
        playerMotor = FindObjectOfType<PlayerMotor>();
    }


    // Update is called once per frame
    void Update()
    {
        if (!playerMotor.isPaused)
        {
            transform.position = Vector3.MoveTowards(transform.position, playerMotor.transform.position, 5f *Time.deltaTime);    
        }
       
    }
}
