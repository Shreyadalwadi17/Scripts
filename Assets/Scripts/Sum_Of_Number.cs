using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sum_Of_Number : MonoBehaviour
{
    public int value = 0;
    public int sum = 0;
    public int reminder;

    private void Start()
    {
        OnSum();
    }

    void OnSum()
    {
        while (value > 0)
        {
            reminder = value % 10;
            Debug.Log("module: " + reminder);
            sum = sum + reminder;
            Debug.Log("sum: " + sum);
            value = value / 10;
            Debug.Log("value: " + value);

        }
        Debug.Log(sum);

    }

}
