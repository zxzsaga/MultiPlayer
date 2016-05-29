using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using System.Collections;

public class ChatView : NetworkBehaviour {

    public Transform viewContent;
    public GameObject chatMessagePrefab;

    [Command]
    public void CmdAddMessage(string msg) {
        GameObject chatMessage = (GameObject)Instantiate(chatMessagePrefab, Vector3.zero, Quaternion.identity);
        NetworkServer.Spawn(chatMessage);
        RpcSyncChatMessage(chatMessage, msg);
    }

    [ClientRpc]
    public void RpcSyncChatMessage(GameObject chatMessage, string msg) {
        chatMessage.transform.SetParent(viewContent);
        chatMessage.GetComponent<Text>().text = msg;
    }


}
