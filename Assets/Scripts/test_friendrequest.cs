using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class test_friendrequest : MonoBehaviour
{
    public TMP_InputField FriendUsernameField;

    private DatabaseManager _dbm;
    private void Start() {
        _dbm = DatabaseManager.instance;
    }
    public void SendFriendRequest()
    {
        _dbm.PostFriendRequestToDatabase();
    }

    public void ConsoleLog()
    {
        Debug.Log("Sending friend request");
    }
}
