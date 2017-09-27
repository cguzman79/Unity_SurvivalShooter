using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitOnEscape : MonoBehaviour {

	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.Escape)){

			if (UnityEditor.EditorApplication.isPlaying) {
				UnityEditor.EditorApplication.isPlaying = false;
			}

			Application.Quit(); // Quits the game
		}
	}
}
