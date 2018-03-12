using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class PlayerHealth : MonoBehaviour
{
    public const double MAX_GPA = 4.0;
    public static double currentGpa = MAX_GPA;
	

    public static void takeDamage(double damage)
    {
        currentGpa -= damage;
        if (currentGpa <= 0.0)
        {
            currentGpa = MAX_GPA;
            print("You died!");
            SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
        }

    }
}
