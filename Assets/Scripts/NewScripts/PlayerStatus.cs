//Turret

using UnityEngine;
using System.Collections;

public class PlayerStatus : MonoBehaviour {

    public int HP; //HP
    public int Energy; //残弾数
    public float bulletSpeed; //弾速

    private InputManager inputManager;
    public GameObject bullet_prefab;
    public GameObject bullet_instance;
    public bool flag;
    public Vector3 offset;

    private AudioSource audioSource;
    public AudioClip audioClip;

    //弾発射
    public void BulletCreater()
    {
        if (inputManager.action && Energy != 0 && flag)
        {
            audioSource.Play();
            Vector3 pos = transform.position.normalized;
            pos.y = 0;
            flag = false;
            bullet_instance = Instantiate(bullet_prefab, pos + offset, Quaternion.identity) as GameObject;
            bullet_instance.GetComponent<Rigidbody>().AddForce(pos * bulletSpeed, ForceMode.VelocityChange);
        }
    }
    //死亡処理
    public void OnDead()
    {
        if (HP <= 0)
        {
            HP = 0;
            Debug.Log("DEAD");
        }
    }

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClip;
        flag = true;
        inputManager = FindObjectOfType<InputManager>();
	}
	
	// Update is called once per frame
	void Update () {
        BulletCreater();
        OnDead();
	}
}
