using UnityEngine;
using System.Collections;

public class WebCamManager : MonoBehaviour {

    public WebCamDevice[] WebCamDevices;
    public WebCamTexture myWebCamTexture;
    public GameObject screen;
	// Use this for initialization
	void Start () {
        WebCamDevices = WebCamTexture.devices;
        Debug.Log("Web cams");
        foreach (var item in WebCamDevices)
            Debug.Log(item);
        if (WebCamDevices.Length > 0)
        {
            myWebCamTexture = new WebCamTexture(WebCamDevices[0].name);
            screen.GetComponent<Renderer>().material.mainTexture = myWebCamTexture;
            myWebCamTexture.Play();
        }
        else
        {
            Debug.LogError("Webカメラを検出できませんでした。");
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
