using UnityEngine;
using System.Collections;

public class MeteorStatus : MonoBehaviour
{

    private MeteorCreater meteorCreater;
    private PlayerStatus playerStatus;

    //トリガー判定
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ground")) //もし、タグが"Ground"なら
        {
            Destroy(meteorCreater.instance); //破棄
            meteorCreater.instance = null;
            meteorCreater.flag = true;
        }
    }

    // Use this inisfor initialization
    void Start()
    {
        meteorCreater = FindObjectOfType<MeteorCreater>();
        playerStatus = FindObjectOfType<PlayerStatus>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
