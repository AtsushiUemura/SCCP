using UnityEngine;
using System.Collections;

public class ExplodeCtrl : MonoBehaviour {

    public GameObject prefab;
    private GameObject instance;
    private AudioSource audioSource;
    public AudioClip audioClip;

    private BulletCtrl bulletCtrl;

    public void Explode(Vector3 positon)
    {
        instance = Instantiate(prefab, positon, Quaternion.identity)as GameObject;
        audioSource.Play();
        StartCoroutine("WaitTime");
    }
    private IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(2.0f);
        Destroy(instance);
        instance = null;
        bulletCtrl.flag = true;
    }
	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClip;
        bulletCtrl = FindObjectOfType<BulletCtrl>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
