using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class InfluencerDB
{
    public static int idCounter;
    public int id;
    public string influencerName;
    public PublicType type;
    public int level;

    public InfluencerDB(PublicType type, string name, int level, int id) {
        this.type = type;
        influencerName = name;
        this.level = level;
        this.id = id;
    }

    public InfluencerDB(PublicType type) {
        this.type = type;
        level = 1;
        influencerName = InfluencerHelper.GetRandomName();
        GenerateId();
    }
    public void GenerateId() {
        id = idCounter;
        idCounter++;
    }
}

public enum PublicType {
    positivism,
    political,
    hater,
    entertainer
}
