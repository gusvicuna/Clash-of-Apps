using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class FriendRequest
{
    public User sender_user;
    public string reciever_user;
    public bool accepted;
    public bool expired;

    public FriendRequest(User sender, string reciever)
    {
        sender_user = sender;
        reciever_user = reciever;
        accepted = false;
        expired = false;
    }
}
