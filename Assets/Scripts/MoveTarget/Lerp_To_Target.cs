using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp_To_Target : MonoBehaviour
{
    public GameObject obj;
    public List<GameObject> points;
    public float speed = 10f;
    //public float elapsedTime = 2;
    //public float desiredDuration = 2;
    public float timer = 0;
    public int lc = 0;

    private void Start()
    {
        //Time.timeScale = 0.1f;
    }
    public void Update()
    {
        timer += Time.deltaTime;
        if (timer <= 1f)
        {

            transform.position = Vector3.Lerp(transform.position, new Vector3(points[lc].transform.position.x, points[lc].transform.position.y, points[lc].transform.position.z), timer * speed);
            //Debug.Log(points.Count);
        }

        if (timer > 1f)
        {
            lc = lc + 1;
            timer = 0f;
        }
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    timer++;
        //    OnMove();
        //}
    }
    //public void OnMove()
    //{

    //    for (int i = 0; i < points.Count; i++)
    //    {

    //        transform.position = Vector3.Lerp(transform.position, new Vector3(points[i].transform.position.x, points[i].transform.position.y, points[i].transform.position.z), timer * speed);
    //        Debug.Log(points.Count);

    //    }
    //}
    public void OnMove()
    {



        if (timer < 1)
        {
            timer += Time.deltaTime;
            transform.position = Vector3.Lerp(transform.position, new Vector3(points[lc].transform.position.x, points[lc].transform.position.y, points[lc].transform.position.z), timer * speed);
            //Debug.Log(points.Count);
        }

        if (timer == 1f)
        {
            lc = lc + 1;
            timer = 0f;
        }

    }
}




