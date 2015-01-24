using UnityEngine;
using System.Collections;
using GGJ15.Helpers;

namespace Tools
{
	public static class Root 
	{
		public static Vector3 origin { get; set; }
	}
}
public class Root : MonoBehaviour {


	void Awake () {
		Tools.Root.origin = this.transform.position;
	}

}
