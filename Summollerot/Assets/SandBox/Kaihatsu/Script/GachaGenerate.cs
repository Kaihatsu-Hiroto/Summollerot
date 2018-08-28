using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GachaGenerate : MonoBehaviour {

    /// <summary>生成するガチャ領域オブジェクト</summary>
    public GameObject m_gachaZone;

    /// <summary>
    /// ガチャ領域を生成
    /// 生成後ジェネレータは削除
    /// </summary>
    private　void Gene(){
        Instantiate(m_gachaZone);
        Destroy(this.gameObject);
    }

    /// <summary>
    /// プレイヤーが触れたらガチャ領域呼び出し
    /// </summary>
    /// <param name="arg_col"></param>
    private void OnTriggerEnter2D(Collider2D arg_col){
        if (arg_col.tag == "Player"){
            Gene();
        }
    }
}
