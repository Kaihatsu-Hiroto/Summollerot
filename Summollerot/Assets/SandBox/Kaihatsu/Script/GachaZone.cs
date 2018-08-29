using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GachaZone : MonoBehaviour {

    [SerializeField][Range(1f,3f)]
    private float m_deleatTime;

    public Roulette m_roulette;
	
	// Update is called once per frame
	void Update () {
        if (!m_roulette.isAngling)
            StartCoroutine("DestroyRolette");
	}

    private IEnumerator DestroyRolette(){
        yield return new WaitForSeconds(m_deleatTime);
        Destroy(gameObject);
    } 
}
