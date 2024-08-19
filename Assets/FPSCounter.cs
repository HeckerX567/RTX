using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPSCounter : MonoBehaviour
{
    public float fps;
    public Text fpstext;

    // Update is called once per frame
    void Update()
    {
        fps = 1.0f / Time.deltaTime;
        fpstext.text = "FPS: " + (int)fps;
    }
}
