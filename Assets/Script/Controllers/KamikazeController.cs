﻿using Script.Manager;
using UnityEngine;

namespace Script.Controllers
{
    public class KamikazeController : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                GameManager.Kill();
            }
        }
    }
}