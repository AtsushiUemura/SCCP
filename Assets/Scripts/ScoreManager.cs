using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {

    public int score;
    public double time;
    public Rect rect;

    void OnGUI()
    {

        GUI.Label(rect, "score: "+score+" time: "+(int)time);

    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        time -= Time.deltaTime;
        if (time <= 0)
        {
            FadeManager.Instance.LoadLevel("SCCP", 2.0f);
        }
	}
}
