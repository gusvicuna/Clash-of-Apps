﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class App
{
    public int id;
    public string appName;
    public Color color;
    public Sprite logo;

    public App(string appName, Color color) {
        this.appName = appName;
        this.color = color;
    }
}
