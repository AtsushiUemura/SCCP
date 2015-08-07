using UnityEngine;
using System.Collections;

public class BulletCtrl : MonoBehaviour
{
    public int HP;

    private InputManager inputManager;
    public GameObject prefab;
    public GameObject instance;
    public bool flag;
    public float bulletSpeed;
    public Vector3 offset;

    private AudioSource audioSource;
    public AudioClip audioClip;

    public void BulletCreate()
    {
        if (inputManager.action && flag)
        {
            audioSource.Play();
            Vector3 pos = transform.position.normalized;
            pos.y = 0;
            flag = false;
            instance = Instantiate(prefab, pos+offset, Quaternion.identity) as GameObject;
            instance.GetComponent<Rigidbody>().AddForce(pos*bulletSpeed, ForceMode.VelocityChange);
        }
    }

    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClip;
        flag = true;
        inputManager = FindObjectOfType<InputManager>();
    }

    // Update is called once per frame
    void Update()
    {
        BulletCreate();
    }
}
