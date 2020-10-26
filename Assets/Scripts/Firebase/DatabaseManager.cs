using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;
using System;
using Proyecto26;

public class DatabaseManager : MonoBehaviour
{
    public void PostFriendRequestToDatabase(FriendRequest fr)
    {
        RestClient.Put("https://clashofapps-1b287.firebaseio.com/" + $"friend_requests/{fr.reciever_user}_from_{fr.sender_user}" + ".json", fr);
        //RestClient.Put("https://clashofapps-1b287.firebaseio.com/" + $"friend_requests/{fr.reciever_user}" + ".json", fr);
    }

    public void GetFriendRequestFromDatabase()
    {
        //RestClient.Ge
    }
}
