using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScirpt : MonoBehaviour
{
    public LayerMask enemyMask;
    public Transform target;
    public float speed;
    Rigidbody2D myBody;
    Transform myTrans;
    float myWidth;

    private void Start()
    {
        myTrans = this.transform;
        myBody = this.GetComponent<Rigidbody2D>();
        myWidth = this.GetComponent<SpriteRenderer>().bounds.extents.x;
    }
    private void Update()
    {
        if (target.position.x >= 7.3)
        {
            float movementDistance = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, movementDistance);
        }
        if (target.GetComponent<BoxCollider2D>().IsTouching(myTrans.GetComponent<BoxCollider2D>()))
        {
            PlayerHealth.takeDamage(0.2);
            //Play animation here
        }
    }
}