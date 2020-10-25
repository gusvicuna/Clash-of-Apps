using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class TurnInfo
{
    public int playerTurn;
    public int maxTurns;
    public int turnNumber;

    public TurnInfo(int playerTurn, int maxTurns, int turnNumber) {
        this.playerTurn = playerTurn;
        this.maxTurns = maxTurns;
        this.turnNumber = turnNumber;
    }
}
