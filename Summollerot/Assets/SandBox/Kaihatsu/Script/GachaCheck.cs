using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GachaCheck : MonoBehaviour {

    public string currentGachaResult;
    public void OnTriggerEnter2D(Collider2D arg_col){
        if (arg_col.tag == "N"){
            currentGachaResult = arg_col.tag;
        }
        if (arg_col.tag == "R"){
            currentGachaResult = arg_col.tag;
        }
        if (arg_col.tag == "SR"){
            currentGachaResult = arg_col.tag;
        }
    }
}
