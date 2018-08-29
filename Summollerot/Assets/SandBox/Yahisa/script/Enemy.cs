using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    //こうもり横移動

    // Use this for initialization
    void Start () {
        

    }

    // Update is called once per frame
    void Update () {
        transform.position = new Vector2(Mathf.PingPong(Time.time, 3), transform.position.y);

    }
}
