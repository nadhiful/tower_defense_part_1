using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour {

	private GameObject[] getCount;
	public int lifepoint;
	public int currentLifepoint;
	public int coin; 
	public int wave;
	public int level;
	public int diedEnemy;
	public int totalEnemy;

	public int count;
	public int alpa;

	public int limit;
	public Text coinText;
	public Text lifepointText;
	public Text waveText;
	public Text quotaText;

	void Start(){
		GameObject[] gos;
		gos = GameObject.FindGameObjectsWithTag ("Enemy");
		count = gos.Length;
	}

	void Awake(){

		waveText.text = wave.ToString ();
		lifepointText.text = currentLifepoint.ToString ();
	}

	public void Win(){
		int halfEnemy = totalEnemy - 3;
		if (diedEnemy == totalEnemy) {
			WinOver ();
		} else if (diedEnemy >= halfEnemy) {
			Debug.Log ("Win Over");
			WinOver ();
		} 
	}

	public void MinusLife(){
		int identity = GameObject.FindObjectOfType<Enemy> ().identity;
		currentLifepoint -= identity;
		if (currentLifepoint <= 0) {
			lifepointText.text = "0";
			GameOver ();
		} else {
			lifepointText.text = currentLifepoint.ToString ();
		}

	}

	IEnumerator delayTest(){
		yield return new WaitForSeconds (10);
		WinOver ();
	}

	public void GameOver(){
		Debug.Log ("Game Over");
		GameObject.FindObjectOfType<BuildManager>().Lose();
		//SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}

	public void WinOver(){
		if (0 < currentLifepoint && currentLifepoint <= lifepoint) {
				Debug.Log (currentLifepoint);
				GameObject.FindObjectOfType<BuildManager> ().Win ();
			}
	}



	void Update(){
		coinText.text = coin.ToString();
		quotaText.text = limit.ToString ();

	}




}
