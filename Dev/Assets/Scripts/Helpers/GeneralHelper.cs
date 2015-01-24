using UnityEngine;
using System.Collections;
using BJW;

namespace BJW.Helpers
{
	public static class GeneralHelper
	{
		public static Vector2 GetScreenSizeInWorldUntits ()
		{
			Vector2 output = new Vector2();

			output.y = Camera.main.orthographicSize * 2;
			output.x = output.y * Camera.main.aspect;
			
			return output;		
		}

		public static Vector3 GetScreenPointInWorldSpace(Enums.ScreenPoints screenPoint)
		{
			Vector3 output = new Vector3();
			Vector3 origin = Scene.Root.transform.position;
			Vector2 screenSize = GetScreenSizeInWorldUntits();

			switch (screenPoint)
			{
				case Enums.ScreenPoints.TopLeft:
					output = new Vector3(origin.x - screenSize.x/2, origin.y + screenSize.y /2, 0);
					break;
				case Enums.ScreenPoints.TopRight:
					output = new Vector3(origin.x + screenSize.x/2, origin.y + screenSize.y /2, 0);					
					break;
				case Enums.ScreenPoints.BottomLeft:
					output = new Vector3(origin.x - screenSize.x/2, origin.y - screenSize.y /2, 0);					
					break;
				case Enums.ScreenPoints.BottomRight:
					output = new Vector3(origin.x + screenSize.x/2, origin.y - screenSize.y /2, 0);
					break;
				case Enums.ScreenPoints.Center:
					output = origin;
					break;
			}

			return output;
		}
	}
}