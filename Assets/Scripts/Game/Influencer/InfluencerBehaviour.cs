using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfluencerBehaviour : MonoBehaviour
{
    public InfluencerDB influencerData;
    public CountryBehaviour country;
    public SpriteRenderer sprite;

    private void Start() {
        SetColor();
    }

    public void SetColor() {
        sprite.color = country.owner.app.color;
    }

    public void ChangeCountry(CountryBehaviour country) {
        this.country = country;
    }
}
