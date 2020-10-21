using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {
    public static UIManager instance;

    //Screen object variables
    public GameObject loginUI;
    public GameObject registerUI;
    public GameObject socialUI;
    public GameObject startUI;

    private void Awake() {
        if (instance == null) {
            instance = this;
        }
        else if (instance != null) {
            Debug.Log("Instance already exists, destroying object!");
            Destroy(this);
        }
    }

    //Functions to change the login screen UI
    public void LoginScreen() //Back button
    {
        loginUI.SetActive(true);
        registerUI.SetActive(false);
        socialUI.SetActive(false);
        startUI.SetActive(false);
    }
    public void RegisterScreen() // Regester button
    {
        loginUI.SetActive(false);
        registerUI.SetActive(true);
        socialUI.SetActive(false);
        startUI.SetActive(false);
    }
    public void FriendRequestScreen() {
        loginUI.SetActive(false);
        registerUI.SetActive(false);
        socialUI.SetActive(true);
        startUI.SetActive(false);
    }
    public void StartScreen()
    {
        loginUI.SetActive(false);
        registerUI.SetActive(false);
        socialUI.SetActive(false);
        startUI.SetActive(true);
    }
}
