using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public enum HexState { inactive, active};

public class BattleHex : MonoBehaviour
{
    public int horizontalCoordinate;
    public int verticalCoordinate;
    public HexState hexState;
    public bool isSecondLevel;
    public Image Landscape;

    public void MakeMeActive()
    {
        hexState = HexState.active;
    }

    public void MakeMeInactive()
    {
        if (hexState != HexState.active)
        {
            Landscape.color = new Color32(170, 170, 170, 255);
        }
    }
}
