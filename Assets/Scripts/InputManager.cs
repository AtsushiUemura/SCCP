using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

    public bool rightBool;
    public bool leftBool;
    
    public bool action;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        action = Input.GetKeyDown(KeyCode.Z);
        rightBool = Input.GetKey(KeyCode.RightArrow);
        leftBool = Input.GetKey(KeyCode.LeftArrow);
	}
}
