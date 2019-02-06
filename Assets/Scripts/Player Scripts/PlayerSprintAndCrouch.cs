﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSprintAndCrouch : MonoBehaviour
{
    private PlayerMovement playerMovement;

    public float sprint_Speed = 10f;
    public float move_Speed = 5f;
    public float crouch_Speed = 2f;

    private Transform look_Root;
    private float stand_Height = 1.6f;
    private float crouch_Height = 1f;

    private bool is_Crouching;

    void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();

        look_Root = transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        Sprint();
        Crouch();
    }

    void Sprint()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) && !is_Crouching)
        {
            playerMovement.speed = sprint_Speed;
        }

        if(Input.GetKeyUp(KeyCode.LeftShift) && !is_Crouching)
        {
            playerMovement.speed = move_Speed;
        }
    } // sprint 

    void Crouch()
    {
        
    }// crouch

} // class
