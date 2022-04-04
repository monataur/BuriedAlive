using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridStuff : MonoBehaviour
{
    public TileType[] tileTypes = new TileType[80];
    public GameObject[] tileObjects = new GameObject[80];
    public SpriteRenderer[] tileRenderer = new SpriteRenderer[80];
    public GameObject[] scaffoldSprites = new GameObject[8];

    public TileType dirt;
    public TileType bubble;

    public bool hasGenerated = false;

    public bool column0blocked = false;
    public bool column1blocked = false;
    public bool column2blocked = false;
    public bool column3blocked = false;
    public bool column4blocked = false;
    public bool column5blocked = false;
    public bool column6blocked = false;
    public bool column7blocked = false;

    public void MoveGridDown()
    {

    }

    TileType[] GenerateRow()
    {
        if(hasGenerated == false)
        {
            TileType[] tempArray = new TileType[8];

            tempArray[0] = dirt;
            tempArray[1] = bubble;
            tempArray[2] = dirt;
            tempArray[3] = bubble;
            tempArray[4] = dirt;
            tempArray[5] = bubble;
            tempArray[6] = dirt;
            tempArray[7] = bubble;

            hasGenerated = true;

            return tempArray;
        }
        else
        {
            return tileTypes;
        }
    }

    private void Update()
    {
        tileTypes = GenerateRow();

        tileRenderer[0].sprite = tileTypes[0].sprite;
        tileRenderer[1].sprite = tileTypes[1].sprite;
        tileRenderer[2].sprite = tileTypes[2].sprite;
        tileRenderer[3].sprite = tileTypes[3].sprite;
        tileRenderer[4].sprite = tileTypes[4].sprite;
        tileRenderer[5].sprite = tileTypes[5].sprite;
        tileRenderer[6].sprite = tileTypes[6].sprite;
        tileRenderer[7].sprite = tileTypes[7].sprite;

        UpdateScaffoldSprites();
    }

    public void UpdateScaffoldSprites()
    {
        switch (column0blocked)
        {
            case true:
                scaffoldSprites[0].SetActive(true);
                break;

            case false:
                scaffoldSprites[0].SetActive(false);
                break;
        }

        switch (column1blocked)
        {
            case true:
                scaffoldSprites[1].SetActive(true);
                break;

            case false:
                scaffoldSprites[1].SetActive(false);
                break;
        }

        switch (column2blocked)
        {
            case true:
                scaffoldSprites[2].SetActive(true);
                break;

            case false:
                scaffoldSprites[2].SetActive(false);
                break;
        }

        switch (column3blocked)
        {
            case true:
                scaffoldSprites[3].SetActive(true);
                break;

            case false:
                scaffoldSprites[3].SetActive(false);
                break;
        }

        switch (column4blocked)
        {
            case true:
                scaffoldSprites[4].SetActive(true);
                break;

            case false:
                scaffoldSprites[4].SetActive(false);
                break;
        }

        switch (column5blocked)
        {
            case true:
                scaffoldSprites[5].SetActive(true);
                break;

            case false:
                scaffoldSprites[5].SetActive(false);
                break;
        }

        switch (column6blocked)
        {
            case true:
                scaffoldSprites[6].SetActive(true);
                break;

            case false:
                scaffoldSprites[6].SetActive(false);
                break;
        }

        switch (column7blocked)
        {
            case true:
                scaffoldSprites[7].SetActive(true);
                break;

            case false:
                scaffoldSprites[7].SetActive(false);
                break;
        }
    }
}
