using UnityEngine;
using System.Collections;
using GGJ15.Helpers;

namespace GGJ15
{
	public static class Root 
	{
		public static Vector3 origin { get; set; }
	}
}

public class Root : MonoBehaviour {

	void Awake () {
		GGJ15.Root.origin = this.transform.position;
	}

	void Start () {


	}
}
