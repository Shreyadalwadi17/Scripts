using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;

public class Test : MonoBehaviour
{
    public List<int> number;
    public List<int> availableNumber;
    public List<TMP_Text> textPlaceholder;
    public List<TMP_Text> btnPlaceholder;
    public TMP_Text extraButton;
    public Canvas canvas1;
    public Canvas canvas2;
    public int counter;
    public int index;


    private void Start()
    {
        canvas1.enabled = true;
        canvas2.enabled = false; 
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RandomNOGenerator();
            for(int i=0;i<number.Count;i++)
            {
                //availableNumber.Add(number);
                availableNumber = number.Distinct().ToList();                                                                                                                                                                                                                                             
                if(availableNumber.Count<3)
                {
                    availableNumber.Add(Random.Range(0, 100));
                }
                textPlaceholder[i].text = availableNumber[i].ToString();
                btnPlaceholder[i].text = availableNumber[i].ToString();

            }
       
        }

    }
    void RandomNOGenerator()
    {
        for (int i = 0; i < number.Count; i++)
        {
            number[i] = Random.Range(0, 100);
        }
        extraButton.text = Random.Range(0, 100).ToString();
    }


}









