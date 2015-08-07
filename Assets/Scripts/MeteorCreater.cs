using UnityEngine;
using System.Collections;

public class MeteorCreater : MonoBehaviour {

    private InputManager inputManager;

    public GameObject[] meteor;
    public GameObject instance;
    public bool flag; //生成可能か判定

    //隕石を降らせる
    public void MeteorRain()
    {
        if (inputManager.action || flag)
        {
            flag = false; //隕石生成不可能
            int rand = Random.Range(0, meteor.Length); //ランダムで隕石の種類を決定
            instance = Instantiate(meteor[rand], transform.position, Quaternion.identity) as GameObject; //隕石を生成
        }
    }

	// Use this for initialization
	void Start () {
        inputManager = FindObjectOfType<InputManager>();
        flag = false;
	}
	
	// Update is called once per frame
	void Update () {
        MeteorRain();
	}
}
