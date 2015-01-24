using UnityEngine;
using System.Collections;
using BJW.Helpers;

namespace BJW
{
	public static class Scene 
	{
		public static Root Root = GameObject.FindGameObjectWithTag ("Root").GetComponent<Root>();

	}
}

/// <summary>
/// This is the serialised Component that stores all the values, to access them you can use the static reference above
/// </summary>
public class Root : MonoBehaviour
{
	//public Vector2 LevelSize = new Vector2();
	public Texture2D LevelMap;
	public Sprite LevelSprite = new Sprite();
}

