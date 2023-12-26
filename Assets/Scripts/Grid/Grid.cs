using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Unity.VisualScripting;

public class Grid : MonoBehaviour

{
    public SpriteRenderer sprite;

    public Color color1;
    public Color color2;
    public Color InitialColor;


    public Vector2 posxy;


    private void Start()
    {
        sprite.color = InitialColor;
    }

    private void OnMouseDown()
    {
        // var YaxixNeighbourUp = new Vector2(0, posxy.y + 1);
        // var YaxixNeighbourDown = new Vector2(0, posxy.y - 1);
        // var XaxixNeighbourRight = new Vector2(posxy.x + 1, 0);
        // var XaxixNeighbourLeft = new Vector2(posxy.x - 1, 0);

        ColorReset();
        RightSide();
        leftSide();
        DownSide();
        Upside();

        upDiagnolSide1();
        DownDiagnol1();

        upDiagnolSide2();
        DownDiagnol2();

    }

    void RightSide()
    {
        var XaxixNeighbourRight = new Vector2(posxy.x + 1, posxy.y);

        for (int i = 0; i < Grid.inst.GetTiles.Count; i++)
        {
            if (Grid.inst.GetTiles[i].posxy == XaxixNeighbourRight)
            {
                Grid.inst.GetTiles[i].sprite.color = color1;
            }
        }
    }

    void leftSide()
    {
        var XaxixNeighbourleft = new Vector2(posxy.x - 1, posxy.y);

        for (int i = 0; i < Grid.inst.GetTiles.Count; i++)
        {
            if (Grid.inst.GetTiles[i].posxy == XaxixNeighbourleft)
            {
                Grid.inst.GetTiles[i].sprite.color = color1;
            }
        }
    }

    void DownSide()
    {
        var YaxixNeighbourDown = new Vector2(posxy.x, posxy.y - 1);

        for (int i = 0; i < Grid.inst.GetTiles.Count; i++)
        {
            if (Grid.inst.GetTiles[i].posxy == YaxixNeighbourDown)
            {
                Grid.inst.GetTiles[i].sprite.color = color1;
            }
        }
    }

    void Upside()
    {
        var YaxixNeighbourUp = new Vector2(posxy.x, posxy.y + 1);

        for (int i = 0; i < Grid.inst.GetTiles.Count; i++)
        {
            if (Grid.inst.GetTiles[i].posxy == YaxixNeighbourUp)
            {
                Grid.inst.GetTiles[i].sprite.color = color1;
            }
        }
    }

    void upDiagnolSide1()
    {
        var YaxixNeighbourUp = new Vector2(posxy.x + 1, posxy.y + 1);

        for (int i = 0; i < Grid.inst.GetTiles.Count; i++)
        {
            if (Grid.inst.GetTiles[i].posxy == YaxixNeighbourUp)
            {
                Grid.inst.GetTiles[i].sprite.color = color2;
            }
        }
    }

    void DownDiagnol1()
    {
        var YaxixNeighbourDown = new Vector2(posxy.x - 1, posxy.y - 1);

        for (int i = 0; i < Grid.inst.GetTiles.Count; i++)
        {
            if (Grid.inst.GetTiles[i].posxy == YaxixNeighbourDown)
            {
                Grid.inst.GetTiles[i].sprite.color = color2;
            }
        }
    }

    void upDiagnolSide2()
    {
        var YaxixNeighbourUp = new Vector2(posxy.x + 1, posxy.y - 1);

        for (int i = 0; i < Grid.inst.GetTiles.Count; i++)
        {
            if (Grid.inst.GetTiles[i].posxy == YaxixNeighbourUp)
            {
                Grid.inst.GetTiles[i].sprite.color = color2;
            }
        }
    }

    void DownDiagnol2()
    {
        var YaxixNeighbourDown = new Vector2(posxy.x - 1, posxy.y + 1);

        for (int i = 0; i < Grid.inst.GetTiles.Count; i++)
        {
            if (Grid.inst.GetTiles[i].posxy == YaxixNeighbourDown)
            {
                Grid.inst.GetTiles[i].sprite.color = color2;
            }
        }
    }
    void ColorReset()
    {
        for (int i = 0; i < Grid.inst.GetTiles.Count; i++)
        {
            Grid.inst.GetTiles[i].sprite.color = InitialColor;
        }

    }
}
