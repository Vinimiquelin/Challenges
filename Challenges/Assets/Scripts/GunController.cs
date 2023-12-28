using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    [SerializeField] private GameObject projectile;
    [SerializeField] private Transform firePoint;

    [SerializeField] private GameObject chargedProjectile;
    [SerializeField] private float chargeSpeed;
    [SerializeField] private float chargeTime;
    
    [SerializeField] private GameObject player;
    
    private bool isCharging;

    // Update is called once per frame
    void Update()
    {
        if (!CutSceneController.isCutSceneOn)
        {
            Flip();
            Fire();
        }
    }

    void Fire()
    {
        if (Input.GetKey(KeyCode.Space) && chargeTime < 2)
        {
            isCharging = true;
            if (isCharging)
            {
                chargeTime += Time.deltaTime * chargeSpeed;
            }
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectile, firePoint.position, firePoint.rotation);
            chargeTime = 0;
        } 
        
        else if (Input.GetKey(KeyCode.Space) && chargeTime >= 2)
        {
            ReleaseCharge();
        }
    }

    void ReleaseCharge()
    {
        Instantiate(chargedProjectile, firePoint.position, firePoint.rotation);
        isCharging = false;
        chargeTime = 0;
    }
    
    void Flip()
    {
        if (Math.Abs(player.transform.localScale.x - 1) < 0.1f && (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)))
            transform.Rotate(0f, 180f, 0f);
        if (Math.Abs(player.transform.localScale.x + 1) < 0.1f && (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)))
            transform.Rotate(0f, 180f, 0f);
    }
}
