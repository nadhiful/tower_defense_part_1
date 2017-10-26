using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour {

	// Use this for initialization
	public void Keluar(){
		//Application.LoadLevel ("Keluar");
		SceneManager.LoadScene("Keluar");	
	}

	public void KeluarEnsiklopedia(){
		//Application.LoadLevel ("Home");
		//GameObject.FindObjectOfType<MusicMenu>().UnDestroyed();
		SceneManager.LoadScene("Home");
	}

	public void Masuk(){
		//Application.LoadLevel ("Home");
		SceneManager.LoadScene("Home");
	}

	public void Quit(){
		Application.Quit ();
	}

	public void Play(){
		SceneManager.LoadScene ("Level1");
	}

	public void HomeEnsiklopedia(){
		//Application.LoadLevel ("HomeEnsikloopedia");
		SceneManager.LoadScene("HomeEnsikloopedia");
	}

	public void HomeEnsiklopedia2(){
		//Application.LoadLevel ("HomeEnsiklopedia2");
		SceneManager.LoadScene("HomeEnsiklopedia2");
	}

	public void GoNeutrofil(){
		SceneManager.LoadScene("Neutrofil");
		//Application.LoadLevel ("Neutrofil");
	}

	public void GoEusinofil(){
		//Application.LoadLevel ("Eusinofil");
		SceneManager.LoadScene("Eusinofil");
	}

	public void GoBasofil(){
		//Application.LoadLevel ("Basofil");
		SceneManager.LoadScene("Basofil");
	}
	public void GoCoba(){
		//Application.LoadLevel ("Basofil");
		SceneManager.LoadScene("Coba");
	}

	public void GoEcoli(){
		//Application.LoadLevel ("Ecoli");
		SceneManager.LoadScene("Ecoli");
	}

	public void GoNorovirus(){
		//Application.LoadLevel ("Norovirus");
		SceneManager.LoadScene("Norovirus");
	}

	public void GoCampylobacter(){
		//Application.LoadLevel ("Campylobacter");
		SceneManager.LoadScene("Campylobacter");
	}

	public void Play2(){
		//Application.LoadLevel ("Campylobacter");
		SceneManager.LoadScene("Level2");
	}

	public void Play3(){
		//Application.LoadLevel ("Campylobacter");
		SceneManager.LoadScene("Level3");
	}

	public void Tutorial(){
		SceneManager.LoadScene ("Tutorial");
	}
}
