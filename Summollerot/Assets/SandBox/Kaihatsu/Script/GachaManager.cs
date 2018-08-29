using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GachaManager : MonoBehaviour {

    private GameObject m_gachaChecer;
    public GachaCheck gachaCheck;

    private GameObject m_roulette;
    public Roulette roulette;

    [HideInInspector]
    public string GachaCheckResult;

    [HideInInspector]
    public bool RouletteActive;

    /// <summary>
    /// 各種参照チェック
    /// </summary>
    private void Check(){
        if (!m_gachaChecer){m_gachaChecer = GameObject.Find("GachaChecker");}
        else{gachaCheck = m_gachaChecer.GetComponent<GachaCheck>();
            GachaCheckResult = gachaCheck.currentGachaResult;
        }

        if (!m_roulette) { m_roulette = GameObject.Find("Roulette"); }
        else { roulette = m_roulette.GetComponent<Roulette>();
            RouletteActive = roulette.isAngling;
        }
    }

    /// <summary>
    /// ガチャ結果
    /// </summary>
    public void Resault(){
        Check();   
        Debug.Log("現在のガチャ結果" + GachaCheckResult);
        Debug.Log("現在のルーレット" + RouletteActive);
    }
    private void Update(){
        Resault();
    }
}
