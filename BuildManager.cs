using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BuildManager : MonoBehaviour {

	public GameObject selectedTower;
	public GameObject MainLayer;
	public GameObject PauseLayer;
	public GameObject WinLayer;
	public GameObject LoseLayer;
	public GameObject PauseButton;

	public Transform player;

	public Text yourScore;
	public Text highScore;
	public int deathScore;
	public int totalScore;
	public int statusMusic;
	public AudioClip _audioclip1;
	public AudioClip _audioclip2;
	public AudioClip _audioclip3;

	void Awake(){
		initScore ();
	}
		
	void initScore(){
		ScoreManager sm = GameObject.FindObjectOfType<ScoreManager> ();
		if (sm.level == 1) {
			string key = "level1";
			if (!PlayerPrefs.HasKey ("level1"))
				PlayerPrefs.SetInt (key, 0);
			yourScore.text = "0";
			highScore.text = PlayerPrefs.GetInt ("level1").ToString ();
		}else if (sm.level == 2) {
			string key = "level2";
			if (!PlayerPrefs.HasKey ("level2"))
				PlayerPrefs.SetInt (key, 0);
			yourScore.text = "0";
			highScore.text = PlayerPrefs.GetInt ("level2").ToString ();
		}else if (sm.level == 3) {
			string key = "level3";
			if (!PlayerPrefs.HasKey ("level3"))
				PlayerPrefs.SetInt (key, 0);
			yourScore.text = "0";
			highScore.text = PlayerPrefs.GetInt ("level3").ToString ();
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void selectTowerType(GameObject prefab){
		selectedTower = prefab;

	}

	public void Pause(){
		MainLayer.gameObject.SetActive (true);
		PauseLayer.gameObject.SetActive (true);
		Time.timeScale = 0;
		Debug.Log ("Pause Menu");
	}

	public void Resume(){
		MainLayer.gameObject.SetActive (false);
		PauseLayer.gameObject.SetActive (false);
		Time.timeScale = 1;
		Debug.Log ("Resume");
	}

	public void Win(){
		playSound2 ();

		MainLayer.gameObject.SetActive (true);
		WinLayer.gameObject.SetActive (true);
		Time.timeScale = 0;
		int templifeScore = GameObject.FindObjectOfType<ScoreManager> ().currentLifepoint;
		int tempcoinScore = GameObject.FindObjectOfType<ScoreManager> ().coin;
		totalScore = deathScore + templifeScore + tempcoinScore;
		yourScore.text = totalScore.ToString ();
		int sm = GameObject.FindObjectOfType<ScoreManager> ().level;
		if (sm == 1) {
			if (PlayerPrefs.GetInt ("level1") < totalScore) {
				PlayerPrefs.SetInt ("level1", totalScore);
				highScore.text = totalScore.ToString ();
			}
		} else if (sm == 2) {
			if (PlayerPrefs.GetInt ("level2") < totalScore) {
				PlayerPrefs.SetInt ("level2", totalScore);
				highScore.text = totalScore.ToString ();
			}
		} else if (sm == 3) {
			if (PlayerPrefs.GetInt ("level3") < totalScore) {
				PlayerPrefs.SetInt ("level3", totalScore);
				highScore.text = totalScore.ToString ();
			}
		}
			
	}

	public void Lose(){
		playSound3 ();
		MainLayer.gameObject.SetActive (true);
		LoseLayer.gameObject.SetActive (true);
		Time.timeScale = 0;
	}

	public void Again(){
		Time.timeScale = 1;
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);	
	}

	public void Exit(){
		GameObject.FindObjectOfType<MusicMenu> ().UnDestroyed ();
		SceneManager.LoadScene ("Home");
	}

	public void playSound(){
		AudioSource audio = GetComponent<AudioSource> ();
		audio.clip = _audioclip1;
		audio.Play ();
	}

	public void playSound2(){
		AudioSource audio = GetComponent<AudioSource> ();
		audio.Stop ();
		audio.clip = _audioclip2;
		audio.PlayOneShot (_audioclip2, 0.5f);
	}

	public void playSound3(){
		AudioSource audio = GetComponent<AudioSource> ();
		audio.Stop ();
		audio.clip = _audioclip3;
		audio.PlayOneShot (_audioclip3, 1f);
	}
}
