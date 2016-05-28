using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Networking.NetworkSystem;
using System.Collections;
using Prototype.NetworkLobby;

public class Player : NetworkBehaviour {
    
    // 运行时
    public LobbyManager lobbyManager;
    private SceneIntroducer sceneIntroducer;
    private MessageHandler messageHandler;

    // 静态绑定

    void Start() {
        sceneIntroducer = GameObject.Find("SceneIntroducer").GetComponent<SceneIntroducer>();
        sceneIntroducer.messageHandler.client = lobbyManager.client;
    }

    public void SpawnGameObject(GameObject go) {
        NetworkServer.Spawn(go);
    }
}
