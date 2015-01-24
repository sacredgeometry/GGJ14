using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using BJW;

namespace BJW.Helpers
{
	public static class LevelHelper
	{
		
		public static List<PolygonCollider2D> GenerateColliderGrid(GameObject go, Vector2 amount, Vector3 multiplier)
		{
			List<PolygonCollider2D> output = new List<PolygonCollider2D>();

			var screenSize = GeneralHelper.GetScreenSizeInWorldUntits();

			if(multiplier != null) { new Vector2 (screenSize.x / multiplier.x, screenSize.y / multiplier.y); }

			Vector2 blockSize = new Vector2(){
				x = screenSize.x / amount.x,
				y = screenSize.y / amount.y
			};

			Vector2 centerOffset = new Vector2(0 - screenSize.x/2, (0 - screenSize.y/2) + blockSize.y);

			for (int x = 0; x < amount.x; x++)
			{
				for (int y = 0; y < amount.y; y++)
				{
					PolygonCollider2D tmpCollider = go.AddComponent<PolygonCollider2D>();

					var tmpPoints = new List<Vector2>(){
						new Vector2(x * blockSize.x, y * blockSize.y)+centerOffset,
						new Vector2(x * blockSize.x + blockSize.x, y * blockSize.y)+centerOffset,
						new Vector2(x * blockSize.x + blockSize.x, y * blockSize.y -  blockSize.y)+centerOffset,
						new Vector2(x * blockSize.x, y * blockSize.y -  blockSize.y)+centerOffset
					};

					tmpCollider.SetPath(0, tmpPoints.ToArray());

					output.Add(tmpCollider);
				}				
			}

			return output;
		}

	}
}

