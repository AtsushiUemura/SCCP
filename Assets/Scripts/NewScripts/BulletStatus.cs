using UnityEngine;
using System.Collections;

public class BulletStatus : MonoBehaviour
{

    private PlayerStatus playerStatus;
    private ExplodeCtrl explodeCtrl;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Target"))
            other.GetComponent<TargetBehaver>().ParticleCreater();
        explodeCtrl.Explode(transform.position);
        playerStatus.bullet_instance = null;
        Destroy(gameObject);
    }

    // Use this for initialization
    void Start()
    {
        explodeCtrl = FindObjectOfType<ExplodeCtrl>();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
