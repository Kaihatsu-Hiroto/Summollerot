using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roulette : MonoBehaviour {

    [SerializeField][Range(1f,5f)]
    private float m_angleSpeed;


	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        transform.eulerAngles += new Vector3(0,0,m_angleSpeed);
    }
}
