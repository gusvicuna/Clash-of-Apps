using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class App
{
    public string appName;
    public Color color;

    public App(string appName, Color color) {
        this.appName = appName;
        this.color = color;
    }
}
