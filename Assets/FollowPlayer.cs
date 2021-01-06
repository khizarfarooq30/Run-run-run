using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private Transform player;

    private void Awake()
    {
        player = FindObjectOfType<PlayerMotor>().transform;
    }

    private void LateUpdate()
    {
        transform.position = player.position;
    }
}
