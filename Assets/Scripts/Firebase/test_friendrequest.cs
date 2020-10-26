using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class test_friendrequest : MonoBehaviour
{
    public TMP_InputField FriendUsernameField;
    public User current_user;

    public DatabaseManager _dbm;
    private void Start() {
        //_dbm = DatabaseManager.instance;
    }
    public void SendFriendRequest()
    {
        //_dbm.PostFriendRequestToDatabase();
        _dbm.SendFriendRequest(new FriendRequest(current_user, FriendUsernameField.text.ToString()));
        Debug.Log("Sending friend request");
    }

}
