using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    [SerializeField] private GameObject obj;

    IEnumerator Fade()
    {
       yield return new WaitForSeconds(0.7f);
       obj.SetActive(false);
    }   

    void OnCollisionEnter() {
        StartCoroutine(Fade());
    }
    
}