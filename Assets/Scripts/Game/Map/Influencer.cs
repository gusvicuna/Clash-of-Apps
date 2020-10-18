using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Influencer
{
    public string influencerName;
    public PublicType type;
}

public enum PublicType {
    positive,
    political,
    hater,
    entertainer
}
