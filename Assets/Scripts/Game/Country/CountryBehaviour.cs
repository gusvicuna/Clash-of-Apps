﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountryBehaviour : MonoBehaviour
{
    public int id;
    public string countryName = "";

    [HideInInspector]
    public GameObject ownerApp;
    [HideInInspector]
    public GameObject[] influencers;

    // Start is called before the first frame update
    void Start() 
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AttackCountry(int influencers, int defenderCountryId) {

    }

    public void AttackCountry(int influencers, int defenderCountryId, Dictionary<int,int> results) {

    }
}
