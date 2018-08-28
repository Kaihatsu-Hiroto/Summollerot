using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roulette : MonoBehaviour {

    /// <summary>回転速度</summary>
    [SerializeField][Range(1f,5f)]
    private float m_angleSpeed;
	
	// Update is called once per frame
	void Update () {
        transform.eulerAngles += new Vector3(0,0,m_angleSpeed);
    }
}
