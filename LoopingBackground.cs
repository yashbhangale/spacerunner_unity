using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    public float backgroundsSpeed;
    public Renderer backgroundRenderer;



    // Update is called once per frame
    void Update()
    {
        backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundsSpeed * Time.deltaTime, 0);
    }
}
