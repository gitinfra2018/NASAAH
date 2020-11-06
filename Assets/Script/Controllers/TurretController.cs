﻿using System;
using System.Collections;
using Script.Manager;
using UnityEngine;

namespace Script.Controllers
{
    public class TurretController : MonoBehaviour
    {
        [SerializeField] private MoveToTarget moveToTarget;
        [SerializeField] private GameManager gameManager;
        [SerializeField] private LayerMask layerMask;
        private bool _isMoving;

        private void OnTriggerEnter2D(Collider2D other)
        {
            
            if ((layerMask & 1 << other.gameObject.layer) == 1 << other.gameObject.layer)
            {
                _isMoving = true;
                var player = gameManager.Player;
                moveToTarget.SetTarget(player);
            }
            
        }

        private void Update()
        {
            if (!_isMoving)
            {
                transform.Rotate (0,0,50*Time.deltaTime);
            }
            else
            {
                transform.rotation = Quaternion.Euler(0,0,0);
            }
            
        }
    }
}