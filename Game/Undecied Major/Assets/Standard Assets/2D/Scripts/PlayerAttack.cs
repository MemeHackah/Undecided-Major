using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour 
{
	public float attackDamage;
	public Transform target;
	Transform myTrans;

	public void Start()
	{
		myTrans = this.transform;
	}
	public void Update () 
	{
		if(Input.GetKeyDown(KeyCode.P))
		{
			//animate attack
			if(target.position.x - myTrans.position.x >= 0.5 && target.position.x - myTrans.position.x < 1)
			{
				print("Hit");
				EnemyScirpt.takeDamage(attackDamage);
			}
		}
	}
}
