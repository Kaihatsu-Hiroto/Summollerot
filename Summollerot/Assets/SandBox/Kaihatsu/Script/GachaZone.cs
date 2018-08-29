using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GachaZone : MonoBehaviour {

    [SerializeField][Range(1f,3f)]
    private float m_deleatTime;

    public Roulette m_roulette;

    private GameObject m_camera;

    private void Start(){
        if (!m_camera)
            m_camera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update () {
        transform.position = m_camera.transform.position;

        if (!m_roulette.isAngling)
            StartCoroutine("DestroyRolette");
	}

    private IEnumerator DestroyRolette(){
        yield return new WaitForSeconds(m_deleatTime);
        Destroy(gameObject);
    } 
}
