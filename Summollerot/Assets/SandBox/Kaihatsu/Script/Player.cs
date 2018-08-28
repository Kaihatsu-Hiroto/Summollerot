using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    /// <summary>スピード</summary>
    [SerializeField][Range(0.1f,0.5f)]
    private float m_speed;

    private Vector3 m_playerSpeed;

    private SpriteRenderer m_spriteRenderer;

    private Rigidbody2D m_rigidbody2D;

	// Use this for initialization
	void Start () {
        m_rigidbody2D = GetComponent<Rigidbody2D>();
        m_spriteRenderer = GetComponent<SpriteRenderer>();
        m_playerSpeed = new Vector3(m_speed, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
        Move();
	}


    private void Move(){

        if (Input.GetKey(KeyCode.RightArrow)){
            transform.position += m_playerSpeed;
            m_spriteRenderer.flipX = false;
        }

        if (Input.GetKey(KeyCode.LeftArrow)){
            transform.position -= m_playerSpeed;
            m_spriteRenderer.flipX = true;
        }
        

    }
}
