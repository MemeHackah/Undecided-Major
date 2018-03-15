using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    private PlayerHealth playerHealth;

	// Use this for initialization
	void Start ()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").transform.GetComponent<PlayerHealth>();
	}

    // Update is called once per frame
    private void OnGUI()
    {
        GUI.TextArea(new Rect(Screen.width / 2 - 400, Screen.height / 2 + 100, 100, 40), "GPA:" + playerHealth.currentGpa);
    }
}
