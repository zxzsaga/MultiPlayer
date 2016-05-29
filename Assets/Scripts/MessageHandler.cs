using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Networking.NetworkSystem;
using System.Collections;

public class MessageHandler : MonoBehaviour {

    public NetworkClient client;    // Player 的 Start 函数里赋值

    public SceneIntroducer sceneIntroducer;

    public class PlayerMessageType {
        public const short Chat = 1001;
    };

    void Start() {
        #if DEBUG_PLAY_SCENE
        return;
        #endif
    }

    public void RegisterHandlers() {
        NetworkServer.RegisterHandler(PlayerMessageType.Chat, OnChatMessage);
    }

    public void SendIntegerMessage(short type, int content) {
        #if DEBUG_PLAY_SCENE
        print("SendIntegerMessage, type: " + type + ", content: " + content);
        return;
        #endif

        IntegerMessage intMsg = new IntegerMessage(content);
        client.Send(type, intMsg);
    }

    public void SendStringMessage(short type, string content) {
        #if DEBUG_PLAY_SCENE
        print("SendStringMessage, type: " + type + ", content: " + content);
        return;
        #endif

        StringMessage strMsg = new StringMessage(content);
        client.Send(type, strMsg);
    }

    public void SendChatMessage(string content) {
        SendStringMessage(PlayerMessageType.Chat, content);
    }
        
    public void OnChatMessage(NetworkMessage msg) {
        StringMessage chatMsg = msg.ReadMessage<StringMessage>();
        print("OnChatMessage: " + chatMsg.value);
    }
}