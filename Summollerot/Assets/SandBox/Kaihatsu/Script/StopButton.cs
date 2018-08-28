using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopButton : MonoBehaviour {

    public Roulette m_roulette;

    public void OnClick(){
        m_roulette.isAngling = false;
    }


}
