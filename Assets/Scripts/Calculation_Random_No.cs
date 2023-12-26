using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Calculation_Random_No : MonoBehaviour
{
    private int num1;
    private int num2;
    private int op;
    public List<string> operators = new List<string>(new[] { "+", "-", "*", "/" });

    public TMP_Text txt1;
    public TMP_Text txt2;
    public TMP_Text optxt;

    public TMP_Text userInput;
    private int ans;
    public string store;
    public string userstore;

    public GameObject panel1;
    public GameObject panel2;


    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GenerateEquation();
            Calculation();
            panel1.SetActive(false);
            panel2.SetActive(false);
        }

    }
    public void GenerateEquation()
    {
        num1 = Random.Range(0, 10);
        num2 = Random.Range(10, 20);
        op = Random.Range(0, operators.Count);

        txt1.text = num1.ToString();
        txt2.text = num2.ToString();
        optxt.text = operators[op].ToString();

    }
    public void Calculation()
    {
        switch (op)
        {
            case 0:
                ans = num1 + num2;
                break;

            case 1:
                ans = num1 - num2;
                break;
            case 2:
                ans = num1 * num2;
                break;
            case 3:
                ans = num1 / num2;
                break;
        }
        store = ans.ToString();
        userstore = userInput.text;

    }
    public void Check()
    {

        if (store == userInput.text)
        {
            panel1.SetActive(true);
        }
        else
        {
            panel2.SetActive(true);
        }
    }
}
