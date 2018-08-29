using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roulette : MonoBehaviour {

    /// <summary>回転速度</summary>
    [SerializeField][Range(1f,10f)]
    private float m_angleSpeed;

    private Rigidbody2D m_rigidbody2D;

    public bool isAngling;

    private void Start(){
        m_rigidbody2D = GetComponent<Rigidbody2D>();
        isAngling = true;
    }

    // Update is called once per frame
    void Update () {
        if (isAngling) {
            transform.eulerAngles += new Vector3(0, 0, m_angleSpeed);
        }
    }
}
