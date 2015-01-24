using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using BJW.Helpers;

public class Level : MonoBehaviour
{
	void Start()
	{
		List<PolygonCollider2D> LevelColliders = LevelHelper.GenerateColliderGrid(this.gameObject, BJW.Scene.Root.LevelColliderResolution);
	}


	void Update()
	{
	
	}
}

