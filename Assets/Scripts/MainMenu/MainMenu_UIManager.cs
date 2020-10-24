using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu_UIManager : MonoBehaviour
{
    public static MainMenu_UIManager instance;

    //Screen object variables
    public GameObject main_menu_ui;
    public GameObject add_friend_ui;
    public GameObject stats_ui;
    public GameObject all_friends_ui;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Debug.Log("Instance already exists, destroying object!");
            Destroy(this);
        }
    }

    //Functions to change the login screen UI
    public void MainMenuScreen() //Back button
    {
        main_menu_ui.SetActive(true);
        add_friend_ui.SetActive(false);
        stats_ui.SetActive(false);
        all_friends_ui.SetActive(false);
    }
    public void AddFriendScreen() // Regester button
    {
        main_menu_ui.SetActive(false);
        add_friend_ui.SetActive(true);
        stats_ui.SetActive(false);
        all_friends_ui.SetActive(false);
    }
    public void StatsScreen()
    {
        main_menu_ui.SetActive(false);
        add_friend_ui.SetActive(false);
        stats_ui.SetActive(true);
        all_friends_ui.SetActive(false);
    }

    public void AllFriendsScreen()
    {
        main_menu_ui.SetActive(false);
        add_friend_ui.SetActive(false);
        stats_ui.SetActive(false);
        all_friends_ui.SetActive(true);
    }
}
