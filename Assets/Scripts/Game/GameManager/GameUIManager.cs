using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUIManager : MonoBehaviour
{
    public static GameUIManager instance;

    //Fase Info
    [Header("Fase UIs")]
    public GameObject HiringFaseUI;
    public GameObject MovingFaseUI;
    public GameObject AttackingFaseUI;
    public GameObject WaitingFaseUI;
    private GameObject currentFaseUI;

    //End Turn
    public GameObject nextTurnUI;

    //Game Settings
    [Header("Game Settings:")]
    public Button settingsButtonUI;
    public GameObject settingsWindowUI;

    private GameManager gameManager;
    private TurnManager turnManager;


    // Start is called before the first frame update
    void Start() {
        if (instance == null) instance = this;
        gameManager = GameManager.instance;
        turnManager = TurnManager.instance;

        gameManager.onFaseChanged += ChangeFase;
        gameManager.onInitGame.AddListener(SetFase);
        gameManager.onEndTurn.AddListener(HideUI);
    }

    private void HideUI() {
        nextTurnUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenSettings() {
        settingsWindowUI.SetActive(true);
        nextTurnUI.SetActive(false);

        settingsButtonUI.onClick.RemoveListener(OpenSettings);
        settingsButtonUI.onClick.AddListener(CloseSettings);
    }

    public void CloseSettings() {
        settingsWindowUI.SetActive(false);
        nextTurnUI.SetActive(true);

        settingsButtonUI.onClick.RemoveListener(CloseSettings);
        settingsButtonUI.onClick.AddListener(OpenSettings);
    }
    public void ChangeFase(GameFase fase) {
        StartCoroutine("ChangeFaseRoutine");
    }
    public void ChangeFase() {
        StartCoroutine("ChangeFaseRoutine");
    }

    public IEnumerator ChangeFaseRoutine() {
        currentFaseUI.GetComponent<Animator>().SetBool("isActive", false);
        yield return new WaitForSeconds(1);
        currentFaseUI.SetActive(false);

        SetFase();
    }

    public void SetFase() {
        Debug.Log("Set Fase");
        GetCurrentFase();

        ActivateFaseUI();
    }

    private void GetCurrentFase() {
        int myTurn = gameManager.myPlayer.turnNumber;
        int playerTurn = turnManager.turnInfo.playerTurn;
        if (playerTurn != myTurn) currentFaseUI = WaitingFaseUI;
        else {
            GameFase fase = gameManager.matchInfo.fase;
            if (fase.Equals(GameFase.Attack)) currentFaseUI = AttackingFaseUI;
            else if (fase.Equals(GameFase.Move)) currentFaseUI = MovingFaseUI;
            else if (fase.Equals(GameFase.Hire)) currentFaseUI = HiringFaseUI;
        }
    }

    private void ActivateFaseUI() {
        currentFaseUI.SetActive(true);
        currentFaseUI.GetComponent<Animator>().SetBool("isActive", true);
    }
}
