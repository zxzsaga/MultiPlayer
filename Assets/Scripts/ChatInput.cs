using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChatInput : MonoBehaviour {

    public MessageHandler messageHandler;

    InputField inputField;

    void Start() {
        inputField = GetComponent<InputField>();
        inputField.onEndEdit.AddListener(CheckAndSendMessage);
    }

    void CheckAndSendMessage(string text) {
        bool inputComplete = (text != "" && Input.GetKey(KeyCode.Return));
        if (inputComplete) {
            messageHandler.SendChatMessage(text);
            inputField.text = "";   
        }
    }
}
