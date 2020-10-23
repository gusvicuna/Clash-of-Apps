using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public TurnManager turnManager;

    public int matchId;

    public List<Player> players;
    public Player myPlayer; //Jugador que esta viendo la pantalla.

    public GameFase fase;

    void Start()
    {
        if (instance == null) instance = this;

        turnManager = GetComponent<TurnManager>();
        turnManager.onTurnsEnded.AddListener(EndGame);
    }

    public void ChangeFase() {
        if (fase.Equals(GameFase.Initialization)) {
            fase = GameFase.Attack;
        }
        else if (fase.Equals(GameFase.Attack)) {
            fase = GameFase.Move;
        }
        else if (fase.Equals(GameFase.Move)) {

        }
    }

    public void EndGame() {

    }
}
public enum GameFase {
    Initialization,
    Attack,
    Move,
    Ending
}
