using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{
    public class Restarter : MonoBehaviour
    {
        public double damage;
        private PlayerHealth playerHp;

        private void Start()
        {
            playerHp = GameObject.FindGameObjectWithTag("Player").transform.GetComponent<PlayerHealth>();
        }
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                playerHp.takeDamage(damage);
            }
        }
    }
}
