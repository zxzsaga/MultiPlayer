using UnityEngine;
using System.Collections;

public class GameState : MonoBehaviour {

    public int playerCount = 0;
    public int resistanceCount = 0;
    public int spyCount = 0;
    public int roundMax = 0;
    public int round = 0;
    public int missionLeader = 0;
    public string playerName = "";

    private PlayMakerFSM playMakerFSM;

    void Start() {
        playMakerFSM = GetComponent<PlayMakerFSM>();
    }

    public void SetPlayerCount(int count) {
        playerCount = count;
    }
    public void SetResistanceCount(int count) {
        resistanceCount = count;
    }
    public void SetSpyCount(int count) {
        spyCount = count;
    }
    public void SetRoundMax(int round) {
        roundMax = round;
    }
    public void SetRound(int round) {
        this.round = round;
    }
    public void SetMissionLeader(int leader) {
        missionLeader = leader;
    }

    public void ToNextRound() {
        round += 1;
    }
    public void PassLeaderShipToNextOne() {
        missionLeader += 1;
        missionLeader %= playerCount;
    }

    public void SetPlayerName(string name) {
        playerName = name;
        playMakerFSM.SendEvent("InputNameOver");
    }
}
