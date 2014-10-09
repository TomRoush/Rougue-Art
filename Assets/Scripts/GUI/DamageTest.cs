using UnityEngine;
using System.Collections;

public class DamageTest : MonoBehaviour {
	
	public HealthBar health;
	
	void OnGUI() {
		
		if (GUI.Button(new Rect(Screen.width / 1.5f,Screen.height/4 + Screen.height/10,100,25),"Take Damage")) {
			health.modifyHealth(0.05f);
		}		
	}
}
