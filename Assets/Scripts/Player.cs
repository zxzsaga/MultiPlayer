using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Networking.NetworkSystem;
using System.Collections;
using Prototype.NetworkLobby;

public class Player : NetworkBehaviour {

    private LobbyManager lobbyManager;
    private SceneIntroducer sceneIntroducer;
    private MessageHandler messageHandler;

    void Start() {
        lobbyManager = GameObject.Find("LobbyManager").GetComponent<LobbyManager>();
        sceneIntroducer = GameObject.Find("SceneIntroducer").GetComponent<SceneIntroducer>();
        messageHandler = GetComponent<MessageHandler>();

        messageHandler.client = lobbyManager.client;
        messageHandler.RegisterHandlers();
        messageHandler.sceneIntroducer = sceneIntroducer;
    }

    public void SpawnGameObject(GameObject go) {
        NetworkServer.Spawn(go);
    }
}
