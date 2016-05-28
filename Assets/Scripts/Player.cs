using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Networking.NetworkSystem;
using System.Collections;
using Prototype.NetworkLobby;

public class Player : NetworkBehaviour {
    
    public string playerName;

    public LobbyManager lobbyManager;

    NetworkClient client;
    MessageHandler messageHandler;

    void Start() {
        client = lobbyManager.client;
        messageHandler.client = client;
    }
}
