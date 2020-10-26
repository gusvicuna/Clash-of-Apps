using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Player
{
    public string name;
    public Color color;
    public List<CountryBehaviour> countries;
    public int influencersToPurchase;
    public int turnNumber;

    public Player(string name, Color color, int influencersToPurchase, int turnNumber) {
        this.name = name;
        this.color = color;
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
