﻿using System;
using UnityEngine;

public class SnowFloor : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Material material;
    public float offsetSpeed = 0.25f;

    private void Awake()
    {
        player = FindObjectOfType<PlayerMotor>().transform;
    }

    private void Update()
    {
        transform.position = Vector3.forward * player.transform.position.z;
        material.SetVector("snowOffset", new Vector2(0, -transform.position.z * offsetSpeed));
    }
}