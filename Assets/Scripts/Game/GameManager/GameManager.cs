using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public MatchInfo matchInfo;
    public Player myPlayer; //Jugador que esta viendo la pantalla.

    public UnityEvent onEndGame;
    public UnityEvent onInitGame;
    public delegate void OnFaseChanged(GameFase fase);
    public OnFaseChanged onFaseChanged;

    void Start()
    {
        if (instance == null) instance = this;

        InitGame();
    }

    public void ChangeToNextFase() {
        if (matchInfo.fase.Equals(GameFase.Initialization)) ChangeFase(GameFase.Attack);
        else if (matchInfo.fase.Equals(GameFase.Attack)) ChangeFase(GameFase.Move);
        else if (matchInfo.fase.Equals(GameFase.Move)) ChangeFase(GameFase.Hire);
        else if (matchInfo.fase.Equals(GameFase.Hire)) ChangeFase(GameFase.Attack);
    }

    public void ChangeFase(GameFase newFase) {
        onFaseChanged(newFase);
        matchInfo.fase = newFase;
    }

    public void EndGame() {
        onEndGame.Invoke();
    }

    public void InitGame() {
        if (onInitGame != null) {
            onInitGame.Invoke();
        }
    }
}
public enum GameFase {
    Initialization,
    Attack,
    Move,
    Hire,
    Ending
}
