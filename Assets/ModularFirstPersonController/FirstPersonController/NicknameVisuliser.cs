using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using TMPro;

public class NicknameVisuliser : NetworkBehaviour
{
    [SerializeField] private GameObject canvas;
    [SerializeField] private TMP_Text nick;
    [SerializeField] private Camera cam;

    //public override void OnStartClient(Client client)
    //{
    //   nick.text = "Player " + "[" + client.connectionId + "]";
    //}

    // Update is called once per frame
    void Update()
    {
        if (canvas.transform.rotation != Camera.main.transform.rotation)
        {
            canvas.transform.rotation = Camera.main.transform.rotation * Quaternion.Euler(180,0,0);
        }
    }
}
