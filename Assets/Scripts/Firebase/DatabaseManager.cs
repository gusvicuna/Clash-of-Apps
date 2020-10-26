using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;
using System;

public class DatabaseManager : MonoBehaviour
{
    FirebaseApp app;
    DatabaseReference reference;

    private void Awake()
    {
        app = Firebase.FirebaseApp.DefaultInstance;
        System.Uri db_uri = new Uri("https://clashofapps-1b287.firebaseio.com/");
        app.Options.DatabaseUrl = db_uri;
        Debug.Log($"Firebase url: {app.Options.DatabaseUrl}");

        reference = FirebaseDatabase.DefaultInstance.RootReference;

        // Get the root reference location of the database.
        //DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;
        /*
        if (true)
        {
            // Create and hold a reference to your FirebaseApp,
            // where app is a Firebase.FirebaseApp property of your application class.
            app = Firebase.FirebaseApp.DefaultInstance;

            // Set a flag here to indicate whether Firebase is ready to use by your app.
            Debug.Log("Firebase available");
            System.Uri db_uri = new Uri("https://clashofapps-1b287.firebaseio.com/");
            app.Options.DatabaseUrl = db_uri;
            //reference = FirebaseDatabase.DefaultInstance.RootReference;
        }
        /*
        Firebase.FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task => {
            var dependencyStatus = task.Result;
            if (dependencyStatus == Firebase.DependencyStatus.Available)
            {
                // Create and hold a reference to your FirebaseApp,
                // where app is a Firebase.FirebaseApp property of your application class.
                app = Firebase.FirebaseApp.DefaultInstance;

                // Set a flag here to indicate whether Firebase is ready to use by your app.
                Debug.Log("Firebase available");
                System.Uri db_uri = new Uri("https://clashofapps-1b287.firebaseio.com/");
                app.Options.DatabaseUrl = db_uri;
                reference = FirebaseDatabase.DefaultInstance.RootReference;
            }
            else
            {
                Debug.LogError(System.String.Format(
                  "Could not resolve all Firebase dependencies: {0}", dependencyStatus));
                // Firebase Unity SDK is not safe to use here.
            }
        });
        */
    }

    public void SendFriendRequest(FriendRequest fr, Action callback, Action<AggregateException> fallback)
    {
        Debug.Log("Sending friend request");
        //reference.Child("FriendRequests").Child(fr.reciever_user).SetValueAsync(fr.sender_user.username);
        reference.Child("friend_requests").Push().SetValueAsync(fr).ContinueWith(task =>
        {
            if (task.IsCanceled || task.IsFaulted) fallback(task.Exception);
            else callback();
        });
    }

    public void ListenForFriendRequest(Action<FriendRequest> callback, Action<AggregateException> fallback)
    {
        void CurrentListener(object o, ChildChangedEventArgs args)
        {
            if (args.DatabaseError != null)
            {
                fallback(new AggregateException(new Exception(args.DatabaseError.Message)));
                Debug.Log(args.DatabaseError.Message);
                return;
            }

            callback(args.Snapshot.Value as FriendRequest);
        }

        reference.Child("friend_requests").ChildAdded += CurrentListener;
    }
}
