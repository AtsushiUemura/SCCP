using UnityEngine;
using System.Collections;

public class BulletStatus : MonoBehaviour
{

    private BulletCtrl bulletCtrl;
    private ExplodeCtrl explodeCtrl;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Target"))
            other.GetComponent<TargetBehaver>().ParticleCreater();
        explodeCtrl.Explode(transform.position);
        bulletCtrl.instance = null;
        Destroy(gameObject);
    }

    // Use this for initialization
    void Start()
    {
        explodeCtrl = FindObjectOfType<ExplodeCtrl>();
        bulletCtrl = FindObjectOfType<BulletCtrl>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
