using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
	// public OVRManager ovr;
	// Use this for initialization
	void Start () {
	}

	void Update () {
		// Debug.Log(OVRInput.Get(OVRInput.Button.One));
		// Debug.Log(OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTrackedRemote));
		Debug.Log(OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger));
	}
}
