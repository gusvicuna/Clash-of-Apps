using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDBManager : MonoBehaviour
{
    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.instance;
        gameManager.onLoadGame.AddListener(LoadGame);
    }

    public void LoadGame() {
        Debug.Log("Loading Game");
        LoadCountries();
    }

    private void LoadCountries() {
        Debug.Log("Loading Countries");
        foreach (CountryBehaviour country in gameManager.allCountries) {
            country.SetInfo(1, gameManager.myPlayer);
        }
    }
}
