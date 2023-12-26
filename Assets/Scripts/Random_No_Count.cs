using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_No_Count : MonoBehaviour

{
    public List<int> num1;
    public List<int> num2;
    public int counter;

    private void Start()
    {
        OnCheckInput();

    }
    void OnCheckInput()
    {
        for (int i = 0; i < num1.Count; i++)
        {
            for (int j = 0 + i; j < num2.Count; j++)
            {
                if (i == num2.Count)
                {
                    counter++;
                }
                Debug.Log("value:" + j);
            }

        }
    }
}

