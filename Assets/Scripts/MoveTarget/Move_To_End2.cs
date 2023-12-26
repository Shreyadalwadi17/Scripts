using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_To_End2 : MonoBehaviour
{

    public Vector3 startPos;
    public Vector3 finalPos;
    //public float speed = 0;    
    public Material material1;
    public Material material2;
    public bool ischeck;
    public float offset = 0;

    private void Start()
    {
        startPos = transform.position + Vector3.left * offset;
        finalPos = transform.position + Vector3.left * -offset;
        //ischeck = true;

        StartCoroutine(LerpPosition(startPos, finalPos, 5f));

        //Debug.Log(Vector3.Lerp(new Vector3(1, 1, 1), new Vector3(10, 15, 20), 0f));//111
        //Debug.Log(Vector3.Lerp(new Vector3(1, 1, 1), new Vector3(10, 15, 20), 0.2f));//< midpoint
        //Debug.Log(Vector3.Lerp(new Vector3(1, 1, 1), new Vector3(10, 15, 20), 1f));//1015520
        //Debug.Log(Vector3.Lerp(new Vector3(1, 1, 1), new Vector3(10, 15, 20), 5f));//101520


    }
    private void Update()
    {
        //OnMove();
    }

    public void OnMove()
    {
        //    if (ischeck)
        //    {
        //        transform.position = Vector3.Lerp(transform.position, startPos, 2f);
        //    }

        //    else
        //    {
        //        transform.position = Vector3.Lerp(transform.position, finalPos, 2f);
        //    }

        //}
    }
    IEnumerator LerpPosition(Vector3 startPosition, Vector3 targetPosition, float duration)
    {
        float time = 0;

        while (time < duration)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, time / duration);

            time += Time.deltaTime;
            yield return null;

            if (time < 1)
            {
                GetComponent<MeshRenderer>().material = material2;
            }
            else
            {

            }
        }
        transform.position = targetPosition;
        StartCoroutine(LerpPosition(targetPosition, startPosition, 5f));
    }
    //transform.position = Vector3.MoveTowards(startObj.transform.position, endObj.transform.position, step);

    //IEnumerator LerpPosition(Vector3 startPosition, Vector3 targetPosition, float duration)
    //{
    //    //float time = 0;

    //    for (int i = 0; i < 5000; i++)
    //    {
    //        transform.position = Vector3.Lerp(startPosition, targetPosition, i / 5000);
    //        Debug.Log("I: " + i);
    //        yield return null;
    //    }
    //}
}
