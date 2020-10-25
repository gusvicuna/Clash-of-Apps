using System.Collections.Generic;
using UnityEngine;

public static class InfluencerHelper {
    public static List<string> names;

    public static string GetRandomName() {
        int randomNamesId = Random.Range(0, names.Count);
        return names[randomNamesId];
    }
}