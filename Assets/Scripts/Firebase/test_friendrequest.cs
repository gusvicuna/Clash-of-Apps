using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class test_friendrequest : MonoBehaviour
{
    public TMP_InputField FriendUsernameField;
    public User current_player;

    private DatabaseManager _dbm;
    public void SendFriendRequest()
    {
        //_dbm.PostFriendRequestToDatabase();
        _dbm.sendFriendRequest(new FriendRequest(current_player, FriendUsernameField.text));
        Debug.Log("Sending friend request");
    }

}
