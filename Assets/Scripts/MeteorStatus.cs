using UnityEngine;
using System.Collections;

public class MeteorStatus : MonoBehaviour {

    private MeteorCreater meteorCreater;
    private BulletCtrl bulletCtrl;

    //トリガー判定
    void OnTriggerEnter(Collider other)
    {
        meteorCreater.flag = true; //生成可能にする
        if (other.CompareTag("Ground")) //もし、タグが"Ground"なら
            Destroy(other.gameObject); //破棄
        if(other.CompareTag("Target"))
            Destroy(other.gameObject;
        if(other.CompareTag("Player"))
            bulletCtrl.HP--;
    }

	// Use this for initialization
	void Start () {
        meteorCreater = FindObjectOfType<MeteorCreater>();
        bulletCtrl = FindObjectOfType<BulletCtrl>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
