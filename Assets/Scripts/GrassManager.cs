using UnityEngine;
using System.Collections;

public class GrassManager : MonoBehaviour {

    public GameObject tile_prefab;
    public GameObject[] tile_instance;
    public int tile_rate;
    public int i;

    public void TilePrint(Vector3 pos)
    {
        tile_instance[i] = Instantiate(tile_prefab, pos, Quaternion.identity) as GameObject;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
