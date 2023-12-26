using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public int rows;
    public int columns;
    public float cellspace;
    public GameObject square;
    public GameObject obj;
    public List<GameObject> triangles;
    public int store;
    public Transform parent;

    private void Start()
    {
        store = Random.Range(0, triangles.Count);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MakeGrid();
        }
    }

    void MakeGrid()
    {
        for (int i = 0; i <= rows; i++)
        {
            for (int j = 0; j <= columns; j++)
            {
                obj = Instantiate(square, new Vector3(i * cellspace, j * cellspace, 0), Quaternion.identity);
               
            }
        }
    }
    public void OnClick()
    {
        square.SetActive(false);
        Debug.Log("click");
    }

   


}
