using UnityEngine;
using System.Collections;

public class InGame {

	static void OnGUI()
	{
		if (Player.gameState == Player.GameState.PAUSED) 
		{
			GUI.Label (new Rect (50, 50, 75, 75), "PAUSED");
			Debug.Log("PAUSED");
			
		}
	}
}
