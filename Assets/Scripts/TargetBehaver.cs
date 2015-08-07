using UnityEngine;
using System.Collections;

public class TargetBehaver : MonoBehaviour
{

    public GameObject hanabira;
    private GameObject instance;
    public Vector3 offset;
    public bool flag = false;
    private ScoreManager scoreManager;
    private AudioSource audioSource;
    public AudioClip audioClip;

    //花びらを生成
    public void ParticleCreater()
    {
        if (!flag)
        {
            audioSource.Play();
            scoreManager.score++;
            flag = true;
            instance = Instantiate(hanabira, transform.position + offset, Quaternion.identity) as GameObject;
            instance.transform.parent = transform;
        }
    }

    // Use this for initialization
    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClip;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
