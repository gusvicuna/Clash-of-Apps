using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;

public class DatabaseManager : MonoBehaviour
{
    DatabaseReference reference;

    void Start()
    {
        // Set up the Editor before calling into the realtime database.
        //FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://clashofapps-1b287.firebaseio.com/"); //Obsolete
        System.Uri db_uri = new System.Uri("https://clashofapps-1b287.firebaseio.com/");
        FirebaseApp.DefaultInstance.Options.DatabaseUrl = db_uri;

        // Get the root reference location of the database.
        reference = FirebaseDatabase.DefaultInstance.RootReference;
    }


    void Update()
    {

    }

    public void sendFriendRequest(FriendRequest fr)
    {
        reference.Child("friend_requests").Child(fr.reciever_user).Child(fr.sender_user.username).SetValueAsync(fr);
    }
}