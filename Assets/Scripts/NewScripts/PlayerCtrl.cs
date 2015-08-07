//GameObject

using UnityEngine;
using System.Collections;

public class PlayerCtrl : MonoBehaviour {

    private InputManager inputManager;
    public Vector2 rotate;

    public void RotateCtrl()
    {
        if (inputManager.leftBool)
            transform.Rotate(0, rotate.x, 0);
        if (inputManager.rightBool)
            transform.Rotate(0, rotate.y, 0);
    }

	// Use this for initialization
	void Start () {
        inputManager = FindObjectOfType<InputManager>();
	}
	
	// Update is called once per frame
	void Update () {
        RotateCtrl();
	}
}
