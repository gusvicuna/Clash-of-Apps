using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
//using Firebase.Database;
using Firebase.Unity.Editor;

public class DatabaseManager : MonoBehaviour
{
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
    //}


}
