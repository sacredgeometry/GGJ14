using UnityEngine;
using System.Collections;
using BJW.Helpers;
using BJW.Extensions;

public class Debugger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		var tet = new BJW.MyClass ();
		GeneralHelper.Init();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
