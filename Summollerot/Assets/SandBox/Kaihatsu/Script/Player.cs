using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    /// <summary>スピード</summary>
    [SerializeField][Range(0.1f,0.5f)]
    private float m_speed;

    /// <summary>ジャンプ力</summary>
    [SerializeField][Range(300f,500f)]
    private float m_jumpPower;

    private Vector3 m_playerSpeed;

    private SpriteRenderer m_spriteRenderer;

    private Rigidbody2D m_rigidbody2D;

    private bool m_isJumping;

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

        /// <summary>右キー入力中</summary>
        if (Input.GetKey(KeyCode.RightArrow)){
            transform.position += m_playerSpeed;
            m_spriteRenderer.flipX = false;
        }

        /// <summary>左キー入力中</summary>
        if (Input.GetKey(KeyCode.LeftArrow)){
            transform.position -= m_playerSpeed;
            m_spriteRenderer.flipX = true;
        }

        /// <summary>上キー入力時</summary>
        if (Input.GetKeyDown(KeyCode.UpArrow)){
            if (m_isJumping){
                m_rigidbody2D.AddForce(transform.up * m_jumpPower);
                m_isJumping = false;
            }
        }
    }

    //着地判定以外はジャンプ不可
    private void OnCollisionEnter2D(Collision2D arg_col){
        if (arg_col.collider.tag == "Ground"){
            m_isJumping = true;
        }
    }
}
