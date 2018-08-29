using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slime : MonoBehaviour {
    public float dir = -1.0f;    //方向：1.0fで右、-1.0fで左
    public float speed = 1.0f;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (dir > 0.1f)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (dir < -0.1f)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        transform.position += new Vector3(dir * speed * Time.deltaTime, 0, 0);

    }
}
