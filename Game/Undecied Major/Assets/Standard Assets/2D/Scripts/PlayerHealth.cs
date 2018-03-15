using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class PlayerHealth : MonoBehaviour
{
    public const double MAX_GPA = 4.0;
    public double currentGpa;
    private Transform player;

    private void Start()
    {
        currentGpa = MAX_GPA;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    public void takeDamage(double damage)
    {
        currentGpa -= damage;
        if (currentGpa <= 0.0)
        {
            currentGpa = MAX_GPA;
            SceneManager.LoadScene(1);
        }
        Vector2 knockUp = player.position;
        knockUp.y += 2;
        knockUp.x -= 2;
        player.position = Vector3.MoveTowards(player.position, knockUp, 30 * Time.deltaTime);
    }

}
