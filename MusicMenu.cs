using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicMenu : MonoBehaviour {

	// Use this for initialization
	static bool AudioBegin = false; 
	public AudioClip _audioclip1;
	public AudioClip _audioclip2;


	void Awake()
	{
		UnDestroyed ();
	}
	void Start(){
		
	}

	void OnEnable(){
		SceneManager.sceneLoaded += OnLevelFinishedLoading;
	}

	void OnDisable(){
		SceneManager.sceneLoaded -= OnLevelFinishedLoading;
	}

	void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
	{
		Debug.Log("Level Loaded");
		Debug.Log(scene.name);
		Debug.Log(mode);
		string nama = scene.name;

		if ((nama == "Level1") || (nama == "Level2") || (nama == "Level3")) {
			AudioSource audio = GetComponent<AudioSource> ();
			audio.Stop ();
			GameObject.FindObjectOfType<BuildManager> ().playSound ();
		}else if (nama == "Home") {
			//UnDestroyed ();
			AudioSource audio = GetComponent<AudioSource> ();
			audio.Stop ();
			audio.clip = _audioclip2;
			audio.Play ();
		}

	}

	public void UnDestroyed(){
		AudioSource audio = GetComponent<AudioSource>();
		if (!AudioBegin) {
			audio.clip = _audioclip2;
			audio.Play ();
			DontDestroyOnLoad (gameObject);
			AudioBegin = true;
		} 
	}

	void Update(){
		
	}


}
