using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class ModelFixs : NetworkBehaviour
{

    public Animator playerAnim;

    void Update()
    {
        if(!isLocalPlayer) return;

        if (Input.GetKey(KeyCode.W))
        {
            //if(!isLocalPlayer) return;
            playerAnim.SetBool("IsRunning", true);
            //playerAnim.avatar = "RunAnimAvatar";
        } else if (Input.GetKey(KeyCode.A)) {
            //if(!isLocalPlayer) return;
            playerAnim.SetBool("IsRunning", true);
            //playerAnim.avatar = "RunAnimAvatar";
        } else if (Input.GetKey(KeyCode.S)) {
            //if(!isLocalPlayer) return;
            playerAnim.SetBool("IsRunning", true);
            //playerAnim.avatar = "RunAnimAvatar";
        } else if (Input.GetKey(KeyCode.D)) {
            //if(!isLocalPlayer) return;
            playerAnim.SetBool("IsRunning", true);
            //playerAnim.avatar = "RunAnimAvatar";
        } else {
            //if(!isLocalPlayer) return;
            playerAnim.SetBool("IsRunning", false);
            //playerAnim.avatar = "Idle (1)Avatar";
        }
    }
}
