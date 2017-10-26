using System.Collections;
using UnityEngine;


public class Spot : MonoBehaviour {
	
	public int status;

	void Start(){
		
	}

	void Update ()
	{
		
	}

	void OnMouseUp(){
		Debug.Log ("Tower Clicked");
		BuildManager mb = GameObject.FindObjectOfType<BuildManager>();
		ScoreManager score = GameObject.FindObjectOfType<ScoreManager> ();
		if (status == 0) {
			if (score.limit == 0) {
				
				Debug.Log ("Kuota sudah habis");
			} else {
				if (mb.selectedTower != null) {
					if (score.coin <= mb.selectedTower.GetComponent<Tower> ().cost) {
						Debug.Log ("Uang gak cukup");
						return;
					}
					score.coin -= mb.selectedTower.GetComponent<Tower> ().cost;
					Instantiate (mb.selectedTower, transform.parent.position, transform.parent.rotation);
					status = 1;
					mb.selectedTower = null;
					if (mb.selectedTower == null) {
						Debug.Log ("Belum milih tower");
					}
					score.limit--;
					Debug.Log (score.limit);
				} else {
					Debug.Log ("Lain");
				}
			}
		} else {
			Debug.Log ("Sudah Ada Tower");
		}
	}

	void backup(){
		int i = 0;
		while (i < Input.touchCount) {

			if (Input.GetTouch (i).phase == TouchPhase.Ended) {
				//Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
				RaycastHit2D hit = Physics2D.Raycast (Camera.main.ScreenToWorldPoint (Input.GetTouch (i).position), -Vector2.up);

				Debug.Log ("TAP !");

				if (hit.collider != null) {
					//playGame ();
				}
			}
			++i;
		}

	}
}
