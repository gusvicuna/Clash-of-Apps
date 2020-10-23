using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TurnManager : MonoBehaviour
{
    public int playerTurn; //A qué jugador le toca jugar.
    public int maxTurns;
    public int turnNumber;

    public UnityEvent onTurnsEnded;

    private GameManager gameManager;

    void Start()
    {
        gameManager = GameManager.instance;
    }

    public void EndTurn() {
        playerTurn += 1;
        if (playerTurn >= gameManager.players.Count) {
            playerTurn = 0;
            turnNumber += 1;
            if (turnNumber > maxTurns) onTurnsEnded.Invoke();
        }
    }
}
