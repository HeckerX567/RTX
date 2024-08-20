using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaScript : MonoBehaviour
{
    [SerializeField] private Transform spawn;

    void OnTriggerEnter(Collider other) {
        other.gameObject.transform.position = spawn.position;
    }
}
