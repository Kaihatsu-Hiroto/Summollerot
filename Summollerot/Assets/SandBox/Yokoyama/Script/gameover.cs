using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour {
    public Rect zahyou = new Rect(0, 0, 100, 50);
    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update () {
		
	}
    void OnGUI()
    {
        GUI.Label(zahyou, "GameOver");   //文字を書く
    }
}
