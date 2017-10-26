using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour {

	void Start(){
		GameObject play = GameObject.FindObjectOfType<BuildManager> ().GetComponent<BuildManager> ().PauseButton;
		Time.timeScale = 0;
		play.gameObject.SetActive (false);
	}
	// Use this for initialization

	void Update(){
		// Code for OnMouseDown in the iPhone. Unquote to test.

	}

	void OnMouseUp(){
		GameObject play = GameObject.FindObjectOfType<BuildManager> ().GetComponent<BuildManager> ().PauseButton;
		play.gameObject.SetActive (true);
		Debug.Log ("Clicked");
		Destroy (gameObject);
		Time.timeScale = 1;

	}

	void backup(){
		RaycastHit hit = new RaycastHit();
		for (int i = 0; i < Input.touchCount; ++i) {
			if (Input.GetTouch(i).phase.Equals(TouchPhase.Ended)) {
				// Construct a ray from the current touch coordinates
				Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
				if (Physics.Raycast(ray, out hit)) {
					hit.transform.gameObject.SendMessage ("playGame");
				}
			}
		}
	}
}
