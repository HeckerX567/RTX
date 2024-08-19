using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using TMPro;

public class RoundSystem : NetworkBehaviour
{
    [SyncVar]
    public float RoundTime;
    public string RoundText;
    public TMP_Text obj;

    [Server]
    void Start()
    {
        RoundTime = 60f;
        RoundText = "Intermission: ";
    }

    [Server]
    void Update()
    {
        if(isLocalPlayer) {
            obj.text = RoundText + (int)RoundTime;
        } else {
           RoundTime -= Time.deltaTime; 
        }
    }
}
