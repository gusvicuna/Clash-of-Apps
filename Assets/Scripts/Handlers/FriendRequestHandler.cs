using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FriendRequestHandler : MonoBehaviour
{
    public DatabaseManager database;

    public User current_user;
    public TMP_InputField username_if;

    public GameObject friendRequestPrefab;

    public Transform friendRequestsContainer;

    private void Start()
    {
        //database.ListenForFriendRequest(InstantiateFriendRequest, Debug.Log);
    }

    public void SendFriendRequest() => 
        database.PostFriendRequestToDatabase(new FriendRequest(current_user, username_if.text));

    private void InstantiateFriendRequest(FriendRequest fr)
    {
        var newFr = Instantiate(friendRequestPrefab, transform.position, Quaternion.identity);
        newFr.transform.SetParent(friendRequestsContainer, false);
        newFr.GetComponent<TextMeshProUGUI>().text = $"{fr.sender_user} wants to be your friend";
    }
}
