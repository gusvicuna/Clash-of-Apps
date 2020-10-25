using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class MatchInfo
{
    public int matchId;
    public List<Player> players;
    public GameFase fase;

    public MatchInfo(int matchId, List<Player> players, int fase) {
        this.matchId = matchId;
        this.players = players;
        this.fase = (GameFase)fase;
    }
}
