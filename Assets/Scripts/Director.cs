using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Director : MonoBehaviour {

    GameLoop gameLoop;
    public int playerCount = 5;
    public int captain = 0;

    public List<bool> taskResult = new List<bool>();

	void Start () {
        UnityEngine.Debug.Log("Start");
        gameLoop = new GameLoop(this);
        gameLoop.Execute();
	}

    public void NamePlayer() {
        UnityEngine.Debug.Log("NamePlayer");
    }
    public void AssignRole() {
        UnityEngine.Debug.Log("AssignRole");
    }
    public void AssignPerformer(int captain) {
        UnityEngine.Debug.Log("AssignPerformer, captain: " + captain);
    }
    public void DiscussPerformer() {
        UnityEngine.Debug.Log("DiscussPerformer");
    }
    public bool VoteOnPerformer() {
        UnityEngine.Debug.Log("VoteOnPerformer");
        bool isPass = false;
        float randomNum = Random.Range(0f, 1f);
        if (randomNum >= 0.5) {
            isPass = true;
        }
        return isPass;
    }
    public void PerformTask() {
        UnityEngine.Debug.Log("PerformTask");
        bool isSuccess = false;
        float randomNum = Random.Range(0f, 1f);
        if (randomNum >= 0.5) {
            isSuccess = true;
        }
        taskResult.Add(isSuccess);
    }
    public bool CheckResult() {
        UnityEngine.Debug.Log("CheckResult");
        int successNum = 0;
        int failedNum = 0;
        for (int i = 0, length = taskResult.Count; i < length; i += 1) {
            if (taskResult[i]) {
                successNum += 1;
            } else {
                failedNum += 1;
            }
        }
        bool needNextTask = (successNum >= 3) || (failedNum >= 3);
        return needNextTask;
    }
}
