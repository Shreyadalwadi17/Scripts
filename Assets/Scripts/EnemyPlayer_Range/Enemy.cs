using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public float Range;
    public Transform player;
    public Vector3 startpos;
    public bool isfollow;
    public float stopRange;
    private float distance;

    private void Start()
    {
        startpos = transform.position;
    }
    private void Update()
    {
        EnemyMove();
        Debug.Log("distance: " + distance);

    }

    void EnemyMove()
    {
        distance = Vector3.Distance(transform.position, player.position);
        Debug.Log(distance);
        if (isfollow)
        {
            if (distance <= Range)
            {
                transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
               
            }
        }
        if (distance < stopRange)
        {
            isfollow = false;
        }
        else
        {
            isfollow = true;
        }
        //else
        //{
        //    isfollow = true;
        //    transform.position = Vector3.MoveTowards(transform.position, startpos, speed * Time.deltaTime);
        //}
    }
}






