using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Influencer
{
    public static int idCounter;
    public int id;
    public string influencerName;
    public PublicType type;
    public int level;

    public Influencer(string name, PublicType type, int level, int id = -1) {
        influencerName = name;
        this.type = type;
        this.level = level;
        if (id < 0) GenerateId();
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
