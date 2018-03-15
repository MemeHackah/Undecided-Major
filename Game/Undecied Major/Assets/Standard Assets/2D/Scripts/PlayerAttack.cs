using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour 
{
	public float attackDamage;
	public Transform target;
	Transform myTrans;
    Animator playerAni;

	public void Start()
	{
		myTrans = this.transform;
        playerAni = GetComponent<Animator>();
	}
	public void Update () 
	{
		if(Input.GetKeyDown(KeyCode.P))
		{
            playerAni.Play("Melee");
            if (((target.position.x - myTrans.position.x >= 0.5 && target.position.x - myTrans.position.x < 1) || 
               (myTrans.position.x - target.position.x >= 0.5 && myTrans.position.x - target.position.x < 1)) && 
                myTrans.position.y <= 0.6)
            {
				EnemyScirpt.takeDamage(attackDamage);
			}
		}
        if(Input.GetKeyUp(KeyCode.P))
        {
            playerAni.Play("Idle");
        }
	}
}
