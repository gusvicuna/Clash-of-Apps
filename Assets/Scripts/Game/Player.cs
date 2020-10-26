using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Player
{
    public App app;
    public List<CountryBehaviour> countries;
    public int influencersToPurchase;
    public int turnNumber;

    public Player(App app, int influencersToPurchase, int turnNumber) {
        this.app = app;
        countries = new List<CountryBehaviour>();
        this.influencersToPurchase = influencersToPurchase;
        this.turnNumber = turnNumber;
    }

    public void AddCountry(CountryBehaviour country) {
        countries.Add(country);
    }

    public void LoseCountry(CountryBehaviour country) {
        countries.Remove(country);
    }

}
