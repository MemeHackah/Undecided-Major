using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyScirpt : MonoBehaviour
{
    public Transform target;
    public float speed;
    private Transform myTrans;
	static float currentHealth;
	public float maxHealth;
    private bool moving = false;
    PlayerHealth playerHp;

    private void Start()
    {
		currentHealth = maxHealth;
        myTrans = this.transform;
        playerHp = target.GetComponent<PlayerHealth>();
    }
    private void Update()
    {
        if ((target.position.x >= 7.3 ) && (target.position.y <= 0.6) || moving)
        {
            float movementDistance = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, movementDistance);
            moving = true;
        }
        if (target.GetComponent<BoxCollider2D>().IsTouching(myTrans.GetComponent<BoxCollider2D>()))
        {
            playerHp.takeDamage(0.2);
        }
    }
	public static void takeDamage(float damage)
	{
		currentHealth -= damage;
		if (currentHealth <= 0) 
		{
			Destroy(GameObject.FindGameObjectWithTag("Enemy"));
            SceneManager.LoadScene(2);
        }
	}
}