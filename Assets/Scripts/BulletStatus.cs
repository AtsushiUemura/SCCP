using UnityEngine;
using System.Collections;

public class BulletStatus : MonoBehaviour
{

    private BulletCtrl bulletCtrl;
    private ExplodeCtrl explodeCtrl;
    private GrassManager grassManager;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Target"))
            other.GetComponent<TargetBehaver>().ParticleCreater();
        explodeCtrl.Explode(transform.position);
        grassManager.TilePrint(transform.position);
        bulletCtrl.instance = null;
        Destroy(gameObject);
        //bulletCtrl.flag = true;
      
    }


    // Use this for initialization
    void Start()
    {
        explodeCtrl = FindObjectOfType<ExplodeCtrl>();
        bulletCtrl = FindObjectOfType<BulletCtrl>();
        grassManager = FindObjectOfType<GrassManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
