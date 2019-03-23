using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPosCamera : MonoBehaviour {
	[SerializeField] SimpleModeControl objSimlMod;
	// Use this for initialization
	void Start () {
		
	}
	public void NextAnim(){
		objSimlMod.EndAnimationMoveCam();
	}
	// Update is called once per frame
	void Update () {
		
	}
}
