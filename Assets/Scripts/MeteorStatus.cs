using UnityEngine;
using System.Collections;

public class MeteorStatus : MonoBehaviour
{

    private MeteorCreater meteorCreater;
    private BulletCtrl bulletCtrl;

    //トリガー判定
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ground")) //もし、タグが"Ground"なら
        {
            Destroy(gameObject); //破棄
            meteorCreater.instance = null;
            meteorCreater.flag = true;
        }
    }

    // Use this for initialization
    void Start()
    {
        meteorCreater = FindObjectOfType<MeteorCreater>();
        bulletCtrl = FindObjectOfType<BulletCtrl>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
