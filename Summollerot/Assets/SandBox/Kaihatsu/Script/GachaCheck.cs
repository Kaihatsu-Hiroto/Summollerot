using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GachaCheck : MonoBehaviour {

    public void OnTriggerEnter2D(Collider2D arg_col)
    {
        Debug.Log(arg_col.tag);
    }
}
