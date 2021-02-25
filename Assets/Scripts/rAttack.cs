﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rAttack : MonoBehaviour
{
    [SerializeField] private GameObject projectile;
    [SerializeField] private Transform shotPoint; 
    [SerializeField] private float shotTime = 0;
    [SerializeField] private float shotDelay = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButton("Fire1") && shotTime <=0){
            Instantiate(projectile, shotPoint.position, shotPoint.rotation);
            shotTime += shotDelay;
        }
        else if(shotTime > 0){
            shotTime -= Time.deltaTime;
        }
        
    }
}
