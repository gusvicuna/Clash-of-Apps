using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public MatchInfo matchInfo;
    public Player myPlayer; //Jugador que esta viendo la pantalla.

    public List<CountryBehaviour> allCountries = new List<CountryBehaviour>();

    public UnityEvent onEndGame;
    public UnityEvent onInitGame;
    public UnityEvent onLoadGame;
    public UnityEvent onEndTurn;
    public delegate void OnFaseChanged(GameFase fase);
    public OnFaseChanged onFaseChanged;

    void Start()
    {
        if (instance == null) instance = this;

        StartCoroutine("StartGameCoroutine");
    }

    public void ChangeToNextFase() {
        if (matchInfo.fase.Equals(GameFase.Initialization)) ChangeFase(GameFase.Attack);
        else if (matchInfo.fase.Equals(GameFase.Attack)) ChangeFase(GameFase.Move);
        else if (matchInfo.fase.Equals(GameFase.Move)) ChangeFase(GameFase.Hire);
        else if (matchInfo.fase.Equals(GameFase.Hire)) {
            TurnManager.instance.EndTurn();
            ChangeFase(GameFase.Attack);
        }
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

    public void LoadGame() {
        Debug.Log("Call load Game");
        if(onLoadGame!=null) onLoadGame.Invoke();
    }

    public IEnumerator StartGameCoroutine() {
        yield return new WaitForSeconds(1);
        LoadGame();
        yield return new WaitForSeconds(1);
        InitGame();
        yield return new WaitForSeconds(1);
    }

    public void ExitGame() {
        SceneManager.LoadScene("MainMenu");
    }
}
public enum GameFase {
    Initialization,
    Attack,
    Move,
    Hire,
    Ending
}
