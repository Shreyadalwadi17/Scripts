using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Count_Of_Names : MonoBehaviour
{
    public List<string> names;
    public int userInput;
    private int store;
    public List<string> a;
    int count = 0;



    private void Start()
    {
        //Check();
        Check();
        //InvokeRepeating("RandomValue", 0f, 1f);
        //CheckOn();
    }

    public void Check()
    {

        for (int i = 0; i < userInput; i++)
        {
            //if(store!=names[i])
            //{

            //}
            store = Random.Range(0, names.Count);
            if (!a.Contains(names[store]))
            {
                a.Add(names[store]);
                Debug.Log(store + " " + names[store]);
            }
            //if ((!a.Contains(names[store]) && count < userInput))
            //{

            //}
        }
    }

    //public void RandomValue()
    //{
    //    int newNumber;
    //    do
    //    {
    //        newNumber = Random.Range(0, names.Count);
    //        a.Add(names[newNumber]);
    //        Debug.Log(newNumber + " " + names[newNumber]);
    //        count++;
    //    }
    //    while (!a.Contains(names[newNumber]) && count<userInput);

    //}


}