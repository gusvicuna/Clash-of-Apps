using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class App
{
    private static int _idCounter;

    [HideInInspector]
    public int id;
    public string appName;
    public Color color;
    [HideInInspector]
    public List<Country> countries;

    public App(string appName, Color color) {
        id = _idCounter;
        _idCounter++;
        this.appName = appName;
        this.color = color;
        countries = new List<Country>();
    }

}
