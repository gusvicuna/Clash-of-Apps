using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountryBehaviour : MonoBehaviour
{
    public string countryName;
    public List<CountryBehaviour> adjacentCountries;

    [HideInInspector]
    public List<InfluencerBehaviour> influencers;
    [HideInInspector]
    public Player owner;
    [HideInInspector]
    public PublicType publicType;

    // Start is called before the first frame update
    void Start() 
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AttackCountry(int influencers, string defenderCountryName, Dictionary<int,int> results = null) {

    }

    public void ChangeOwner(Player newOwner) {
        owner = newOwner;
    }

    public void AddInfluencer(InfluencerBehaviour newInfluencer) {
        influencers.Add(newInfluencer);
    }

    public void RemoveInfluencer(InfluencerBehaviour influencer) {
        influencers.Remove(influencer);
    }
}
