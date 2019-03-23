using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContolStartVr : MonoBehaviour {
	public GameObject buttonVrMod;
	// Use this for initialization
	void Start () {
		
	}
	public void ActiveCanvas(){
		if (buttonVrMod.activeSelf) {
			buttonVrMod.SetActive (false);
		} else {
			buttonVrMod.SetActive (true);
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
