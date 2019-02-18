using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour {

    GameObject hpGauge;

	void Start () {
        this.hpGauge = GameObject.Find("hpGauge");
	}
	
	public void DecreaseHp () {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
	}
}
