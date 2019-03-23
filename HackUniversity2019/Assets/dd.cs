using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class dd : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Camera.main.GetComponent<Transform>().localRotation = UnityEngine.VR.InputTracking.GetLocalRotation(VRNode.CenterEye);
	}
}
