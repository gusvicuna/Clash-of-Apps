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
    public int influencers = 1;
    public string countryName;
    [HideInInspector]
    public App ownerApp;
    public List<CountryBehaviour> adjacentCountries;

    public Country(string countryName, App ownerApp, List<CountryBehaviour> adjacentCountries) {
        id = _idCounter;
        _idCounter++;
        this.adjacentCountries = adjacentCountries;
        this.countryName = countryName;
        this.ownerApp = ownerApp;
    }

}
