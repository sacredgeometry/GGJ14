using UnityEngine;
using System.Collections;
using BJW.Helpers;
using BJW.Constants;

namespace BJW
{
	public static class Scene 
	{
		public static Root Root = GameObject.FindGameObjectWithTag (Constants.Tags.Root).GetComponent<Root>();

		public static Level Level = GameObject.FindGameObjectWithTag(Constants.Tags.Level).GetComponent<Level>();
		public static GameObject LevelCollider = GameObject.FindGameObjectWithTag(Constants.Tags.LevelCollider);
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
	public Vector2 LevelColliderResolution = new Vector2(5, 5);
}

