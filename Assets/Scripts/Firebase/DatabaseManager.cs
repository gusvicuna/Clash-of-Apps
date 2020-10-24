using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;

public class DatabaseManager : MonoBehaviour
{
    public DependencyStatus dependencyStatus;

    DatabaseReference reference;
    FirebaseDatabase fb_database;

    [System.Obsolete]
    private void Start()
    {
        // Set up the Editor before calling into the realtime database.
        System.Uri db_uri = new System.Uri("https://clashofapps-1b287.firebaseio.com/");
        //FirebaseApp.DefaultInstance.Options.DatabaseUrl = db_uri;

        // Get the root reference location of the database.
        //reference = FirebaseDatabase.DefaultInstance.RootReference;
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task =>
        {
            dependencyStatus = task.Result;
            if (dependencyStatus == DependencyStatus.Available)
            {
                //If they are avalible Initialize Firebase
                InitializeFirebase();
                //FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://clashofapps-1b287.firebaseio.com/");
                FirebaseApp.DefaultInstance.Options.DatabaseUrl = db_uri;
            }
            else
            {
                Debug.LogError("Could not resolve all Firebase dependencies: " + dependencyStatus);
            }
        });
    }

    private void InitializeFirebase()
    {
        Debug.Log("Setting up Firebase Database");
        //Set the authentication instance object
        fb_database = FirebaseDatabase.DefaultInstance;
    }

    public void SendFriendRequest(FriendRequest fr)
    {
        reference.Child("FriendRequests").Child(fr.reciever_user).SetValueAsync(fr.sender_user.username);
    }
    /*
    public static DatabaseManager instance;
    //private FirebaseDatabase _database;
    //private DatabaseReference _reference;

   // private FirebasInit _init;

    private void Awake() {
        if (instance == null) {
            instance = this;
        }
        else if (instance != null) {
            Debug.Log("Instance already exists, destroying object!");
            Destroy(this);
        }
    }

    //private void Start() {
    //    _init = GetComponent<FirebasInit>();
    //    _init.OnFirebaseInitialized.AddListener(GetDatabaseInstance);
    //}

    //void GetDatabaseInstance() {
    //    _database = FirebaseDatabase.DefaultInstance;
    //    _reference = _database.RootReference;
    //    Debug.Log("Database instanciated");
    //}
    //public void PostFriendRequestToDatabase()
    //{
    //    _reference.Child("notifications").Child("gus").Child("friend_requests").Child("Maria").SetValueAsync(true);
    //}*/
}
