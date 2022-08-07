using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldManager : MonoBehaviour
{
    public RowManager[] allRows;
    public BattleHex[,] allHexesArray;
    int allRowsLength;
  
    void Start()
    {
        allRows = GetComponentsInChildren<RowManager>();
        allRowsLength = allRows.Length;
        for(int i = 0; i < allRowsLength; i++)
        {
            allRows[i].allHexesInRow = allRows[i].GetComponentsInChildren<BattleHex>();
        }
        CreateAllHexesArray();
    }

    private void CreateAllHexesArray()
    {
        int heightOfArray = allRows.Length;
        int widthOfArray = allRows[0].allHexesInRow.Length;
        allHexesArray = new BattleHex[widthOfArray, heightOfArray];

        for(int j = 0; j < heightOfArray; j++)
        {
            for (int i = 0; i < widthOfArray; i++)
            {
                allHexesArray[i, j] = allRows[heightOfArray-1- j].allHexesInRow[widthOfArray - 1 - i];
                allHexesArray[i, j].verticalCoordinate = j+1;
                allHexesArray[i, j].horizontalCoordinate = i + 1;
            }
        }
        
    }

    private void CreateActiveHexesArray()
    {
        foreach ( BattleHex hex in allHexesArray)
        {
            if(hex.transform.position.x > 11.3f |
                hex.transform.position.x < -11.3f |
                hex.transform.position.y > 6.2f |
                hex.transform.position.y < -6.2f)
            {
                hex.MakeMeInactive();
            }
            else
            {
                hex.MakeMeActive();
            }
        }
    }
}
