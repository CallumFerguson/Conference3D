using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Projector projector;

    public Renderer quadRend;

    void Start()
    {
        WebCamTexture webcamTexture = new WebCamTexture();

        Material newMaterial = new Material(projector.material);
        newMaterial.mainTexture = webcamTexture;
        projector.material = newMaterial;

        quadRend.material.mainTexture = webcamTexture;

        webcamTexture.Play();

        float aspectRatio = (float)webcamTexture.width / (float)webcamTexture.height;
        float scale = quadRend.gameObject.transform.localScale.x;

        quadRend.gameObject.transform.localScale = new Vector3(aspectRatio * scale, scale, 1);
    }

    void Update()
    {

    }
}