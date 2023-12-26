using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_To_End1 : MonoBehaviour
{
    public GameObject startObj;
    public GameObject endObj;
    public Vector3 startPos;
    public Vector3 finalPos;
    public float distance;
    public float speed = 0;
    public Material material1;
    public Material material2;
    public float step;
    public bool ischeck;
    public float offset = 0;

    private void Start()
    {
        startPos = transform.position + Vector3.left * offset;
        finalPos = transform.position + Vector3.left * -offset;
        ischeck = true;
        startPos = transform.position;
        float dist = Vector3.Distance(startObj.transform.position, endObj.transform.position);

    }
    private void Update()
    {
        OnMove();
    }

    public void OnMove()
    {
        if (ischeck)
        {
            step = speed * Time.deltaTime;
            transform.position += Vector3.left * step;
        }
        else
        {
            step = speed * Time.deltaTime;
            transform.position += Vector3.left * -step;
        }
    }

    //transform.position = Vector3.MoveTowards(startObj.transform.position, endObj.transform.position, step);



    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("colide");
        if (collision.gameObject.CompareTag("ball"))
        {
            GetComponent<MeshRenderer>().material = material2;
            ischeck = false;
            Debug.Log("blue");
        }
        if (collision.gameObject.CompareTag("ballback"))
        {
            OnMove();
            ischeck = true;
            GetComponent<MeshRenderer>().material = material1;
            Debug.Log("red");

        }

    }


}
