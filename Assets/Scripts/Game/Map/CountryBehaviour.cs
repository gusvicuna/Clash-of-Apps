using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class CountryBehaviour : MonoBehaviour
{
    public string countryName;
    public List<CountryBehaviour> adjacentCountries;
    public int influencers;
    public Player owner;

    public SpriteShapeRenderer sprite;
    public TextMeshPro influencersUI;

    private void Start() {
        GameManager.instance.allCountries.Add(this);
        GameManager.instance.onInitGame.AddListener(SetVisualInfo);
    }
    private void SetVisualInfo() {
        sprite.color = owner.color;
        influencersUI.text = influencers.ToString();
    }

    public void SetInfo(int influencers, Player owner) {
        this.owner = owner;
        this.influencers = influencers;
    }

    public void AttackCountry(int influencers, string defenderCountryName) {

    }

    public void ChangeOwner(Player newOwner) {
        owner = newOwner;
    }

    public void AddInfluencer() {
        influencers += 1;
    }

    public void RemoveInfluencer() {
        influencers -= 1;
    }
}
