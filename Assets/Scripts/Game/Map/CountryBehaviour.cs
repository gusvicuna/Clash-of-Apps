using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.U2D;

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

    public SpriteShapeRenderer sprite;

    // Start is called before the first frame update
    void Start() {
        SetColor();
    }

    private void SetColor() {
        sprite.color = owner.app.color;
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
        newInfluencer.ChangeCountry(this);
    }

    public void RemoveInfluencer(InfluencerBehaviour influencer) {
        influencers.Remove(influencer);
    }
}
