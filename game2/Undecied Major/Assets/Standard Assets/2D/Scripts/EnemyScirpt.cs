using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScirpt : MonoBehaviour
{
    public Transform Player;
    private int MoveSpeed = 4;
    private int MaxDist = 10;
    private int MinDist = 5;

    void Start()
    {

    }

    void Update()
    {
        transform.LookAt(Player);

        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        {

            transform.position += transform.forward * MoveSpeed * Time.deltaTime;

        }
    }
}