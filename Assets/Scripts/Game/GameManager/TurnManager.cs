using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public static TurnManager instance;
    public TurnInfo turnInfo;

    private GameManager _gameManager;

    void Start()
    {
        if (instance == null) instance = this;
        _gameManager = GameManager.instance;
    }

    public void EndTurn() {
        _gameManager.onEndTurn.Invoke();
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
}
