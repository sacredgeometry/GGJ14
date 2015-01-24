using UnityEngine;
using System.Collections;

namespace BJW.Helpers
{
	public static class GeneralHelper
	{
		public static void Init ()
		{
			Debug.Log (Scene.Root.LevelSize.ToString ());
		}
	}
}