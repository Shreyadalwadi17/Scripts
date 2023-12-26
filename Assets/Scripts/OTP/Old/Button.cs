using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Button : MonoBehaviour
{
    public Test test;

    public void OnButtonClick()
    { 
        for (int i = 0; i < test.textPlaceholder.Count; i++)
        {  
            if (GetComponentInChildren<TextMeshProUGUI>().text == test.textPlaceholder[test.index].text)
            {
                test.counter++;
                test.index++;
                GetComponent<Image>().color = Color.green;
                Debug.Log("the text " + gameObject.GetComponentInChildren<TextMeshProUGUI>().text);
              
                if (test.counter == 3 && test.index==3)
                {
                    StartCoroutine(WaitAndPrint());     
                }
            }
            else
            { 
                Debug.Log("Not Found");
            }
        }

    }
    private IEnumerator WaitAndPrint()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            test.canvas2.enabled = true;
            test.canvas1.enabled = false;
        }
    }
}
