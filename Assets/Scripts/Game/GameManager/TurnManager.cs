﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public TurnInfo turnInfo;

    private GameManager _gameManager;

    void Start()
    {
        _gameManager = GameManager.instance;
        _gameManager.onFaseChanged += CheckIfEndOfTurn;
    }

    public void EndTurn() {
        turnInfo.playerTurn += 1;
        int playerCount = _gameManager.matchInfo.players.Count;
        if (turnInfo.playerTurn >= playerCount) {
            turnInfo.playerTurn = 0;
            turnInfo.turnNumber += 1;
            if (turnInfo.turnNumber > turnInfo.maxTurns) {
                _gameManager.EndGame();
            }
        }
    }

    public void CheckIfEndOfTurn(GameFase fase) {
        if (fase.Equals(GameFase.Buy)) EndTurn();
    }
}