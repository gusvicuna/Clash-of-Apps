using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Country {

    private static int _idCounter;

    [HideInInspector]
    public int id;
    [HideInInspector]
    public List<InfluencerBehaviour> influencers;
    [HideInInspector]
    public App owner;

    public Country(App ownerApp) {
        id = _idCounter;
        _idCounter++;
        this.owner = ownerApp;
    }

}
