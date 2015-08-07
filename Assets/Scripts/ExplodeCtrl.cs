using UnityEngine;
using System.Collections;

public class ExplodeCtrl : MonoBehaviour
{

    public GameObject prefab;
    private GameObject instance;
    private AudioSource audioSource;
    public AudioClip audioClip;

    private PlayerStatus playerStatus;

    public void Explode(Vector3 positon)
    {
        instance = Instantiate(prefab, positon, Quaternion.identity) as GameObject;
        audioSource.Play();
        StartCoroutine("WaitTime");
    }
    private IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(2.0f);
        Destroy(instance);
        instance = null;
        playerStatus.flag = true;
    }
    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClip;
        playerStatus = FindObjectOfType<PlayerStatus>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
