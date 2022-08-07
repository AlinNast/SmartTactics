using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum HexState { inactive, active};

public class BattleHex : MonoBehaviour
{
    public int horizontalCoordinate;
    public int verticalCoordinate;
    public HexState hexState;
    public bool isSecondLevel;
}
