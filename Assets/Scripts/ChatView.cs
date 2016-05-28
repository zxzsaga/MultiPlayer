using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChatView : MonoBehaviour {

    public Transform viewContent;
    public GameObject chatMessagePrefab;

    public void AddMessage(string msg) {
        GameObject chatMessage = (GameObject)Instantiate(chatMessagePrefab, Vector3.zero, Quaternion.identity);
        chatMessage.transform.SetParent(viewContent);
        chatMessage.GetComponent<Text>().text = msg;
    }
}
