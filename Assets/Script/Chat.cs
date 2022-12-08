using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chat : Photon.MonoBehaviour
{

    public List<string> chatList = new List<string>();
    public Text chatBox;
    public InputField input;

    public InputField Nickname;

    public void SendButton()
    {
        if (PhotonNetwork.player.NickName == null)
        {
            print("can't send message because your nickname is not filled");
        }
        else
        {
            string currentMsg = input.text;

            Send(PhotonTargets.All, currentMsg);
            input.text = string.Empty;
        }

        
    }

    void Send(PhotonTargets _target, string _msg)
    {
        photonView.RPC("SendMsg", _target, _msg);
    }

    [PunRPC]
    void SendMsg(string _msg, PhotonMessageInfo _info)
    {
        AddChatBox(string.Format("{0}: {1}", _info.sender, _msg));
    }

    void AddChatBox(string _msg)
    {
        string chat = chatBox.text;
        chat += string.Format("\n{0}", _msg);
        chatBox.text = chat;

        chatList.Add(_msg);
    }



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Return)) SendButton();
	}

    public void ChangeNickname()
    {
        PhotonNetwork.playerName = Nickname.text;
    }
}
