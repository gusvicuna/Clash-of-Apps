using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class User
{
    public string username;
    public int friends;

    public User(string _username, int _friends)
    {
        username = _username;
        friends = _friends;
    }
}
