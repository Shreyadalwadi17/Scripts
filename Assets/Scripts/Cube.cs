using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : MonoBehaviour
{
    private Vector3 targetposition;
    private float movementspeed = 5f;

    // Start is called before the first frame update
    void Start()
    {

        float x = Random.Range(0f, Screen.width);
        float y = Random.Range(0f, Screen.height);
        targetposition = Camera.main.ScreenToWorldPoint(new Vector3(x, y, 0f));

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            float x = Random.Range(0f, Screen.width);
            float y = Random.Range(0f, Screen.height);
            targetposition = Camera.main.ScreenToWorldPoint(new Vector3(x, y, 0f));

            Vector3 direction = targetposition - transform.position;
            direction.Normalize();

            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.position += direction * movementspeed * Time.deltaTime;

        }

    }
}



//////1 code
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : MonoBehaviour
{
    private Vector3 targetposition;
    private float movementspeed = 5f;
    public GameObject Point1;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            targetposition = new Vector3(Random.Range(-5, 5), Random.Range(4, -4), 0f);
            Point1.transform.position = targetposition;
            transform.up = targetposition - transform.position;
        }
        transform.position = Vector3.MoveTowards(transform.position, Point1.transform.position, movementspeed * Time.deltaTime);


    }
}

//////2 code

    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public Transform startPoint;
    public Transform endPoint;
    public float duration = 2f;

    private float startTime;
    private Vector3 startPos;
    private Vector3 endPos;

    void Start()
    {
        startTime = Time.time;
        startPos = startPoint.position;
        endPos = endPoint.position;
    }

    void Update()
    {
        float t = (Time.time - startTime) / duration;
        t = Mathf.Clamp01(t); // Clamp t to range [0, 1]

        // Calculate the y-coordinate of the parabolic trajectory
        float height = Mathf.Sin(t * Mathf.PI) * 2f; // Adjust this value to change the height of the trajectory

        // Interpolate the position of the object between the start and end points
        transform.position = Vector3.Lerp(startPos, endPos, t) + Vector3.up * height;
    }
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{

    public Transform startPoint;
    public Transform endPoint;
    public float duration = 2f;

    private float startTime;
    private Vector3 startPos;
    private Vector3 endPos;
    bool call = false;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        startPos = startPoint.position;
        endPos = endPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (call == true)
        {
            float t = (Time.time - startTime) / duration;
            t = Mathf.Clamp01(t);
            float height = Mathf.Sin(t * Mathf.PI) * 2f;
            transform.position = Vector3.Lerp(startPos, endPos, t) + Vector3.up * height;

        }
        if (Input.GetKey(KeyCode.Space))
        {
            call = true;
        }
        if (call == false)
        {

        }

    }
}
