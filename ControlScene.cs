using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlScene : MonoBehaviour {

	public GameObject[] Panel;
	public int indexPanel;
	public int counter;
	public GameObject ButtonNext;
	public GameObject ButtonReverse;
	public GameObject ButtonExit;
	public GameObject MainLayer;
	public GameObject Layer1;
	public GameObject EnemyLayer;
	public GameObject AntivirusLayer;
	public GameObject Tutor1Layer;
	public GameObject Tutor2Layer;
	public GameObject Tutor3Layer;
	public GameObject Tutor4Layer;
	public GameObject Tutor5Layer;
	public GameObject Tutor6Layer;
	public GameObject Tutor7Layer;
	public GameObject PanelInfo;



	// Use this for initialization
	void Start () {
			
	}
	
	// Update is called once per frame
	public void MovePanel(){
		ControlScene cs = GameObject.FindObjectOfType<ControlScene> ();
		int x = cs.indexPanel;
		indexPanel = x + 1;

		if (indexPanel == 1) {
			Panel2 ();
		} else if (indexPanel == 2) {
			Panel1 ();
		} else if (indexPanel == 3) {
			Panel3 ();
		} else if (indexPanel == 4) {
			Panel4 ();
		} else if (indexPanel == 5) {
			Panel5 ();
		} else if (indexPanel == 6) {
			Panel6 ();
		} else if (indexPanel == 7) {
			Panel7 ();
		} else if (indexPanel == 8) {
			Panel8 ();
		} else if (indexPanel == 9) {
			Panel9 ();
			ButtonNext.gameObject.SetActive (false);
		}
			
	}
	public void ReversePanel(){
		ControlScene cs = GameObject.FindObjectOfType<ControlScene> ();
		int x = cs.indexPanel;
		indexPanel = x - 1;
		if (indexPanel == 1) {
			Panel2 ();
			ButtonExit.gameObject.SetActive (false);
		} else if (indexPanel == 2) {
			Panel1 ();

		} else if (indexPanel == 3) {
			Panel3 ();

		} else if (indexPanel == 4) {
			Panel4 ();

		} else if (indexPanel == 5) {
			Panel5 ();

		} else if (indexPanel == 6) {
			Panel6 ();

		} else if (indexPanel == 7) {
			Panel7 ();

		} else if (indexPanel == 8) {
			Panel8 ();

		} else if (indexPanel == 9) {
			Panel9 ();

		}
	}

	public void ClosePanel(){
		MainLayer.gameObject.SetActive (false);
	}

	void Panel1(){
		Layer1.gameObject.SetActive (false);
		EnemyLayer.gameObject.SetActive (true);
		AntivirusLayer.gameObject.SetActive (false);
		ButtonNext.gameObject.SetActive (false);
		ButtonNext.gameObject.SetActive (false);
		ButtonReverse.gameObject.SetActive (false);
		Tutor1Layer.gameObject.SetActive (false);
		Tutor2Layer.gameObject.SetActive (false);
		Tutor3Layer.gameObject.SetActive (false);
		Tutor4Layer.gameObject.SetActive (false);
		Tutor5Layer.gameObject.SetActive (false);
		Tutor6Layer.gameObject.SetActive (false);
		Tutor7Layer.gameObject.SetActive (false);
	}

	void Panel2(){
		Layer1.gameObject.SetActive (false);
		EnemyLayer.gameObject.SetActive (false);
		AntivirusLayer.gameObject.SetActive (true);
		ButtonNext.gameObject.SetActive (false);
		ButtonReverse.gameObject.SetActive (false);
		Tutor1Layer.gameObject.SetActive (false);
		Tutor2Layer.gameObject.SetActive (false);
		Tutor3Layer.gameObject.SetActive (false);
		Tutor4Layer.gameObject.SetActive (false);
		Tutor5Layer.gameObject.SetActive (false);
		Tutor6Layer.gameObject.SetActive (false);
		Tutor7Layer.gameObject.SetActive (false);
	}

	void Panel3(){
		AntivirusLayer.gameObject.SetActive (false);
		EnemyLayer.gameObject.SetActive (false);
		ButtonNext.gameObject.SetActive (true);
		ButtonReverse.gameObject.SetActive (true);
		Tutor1Layer.gameObject.SetActive (true);
		Tutor2Layer.gameObject.SetActive (false);
		Tutor3Layer.gameObject.SetActive (false);
		Tutor4Layer.gameObject.SetActive (false);
		Tutor5Layer.gameObject.SetActive (false);
		Tutor6Layer.gameObject.SetActive (false);
		Tutor7Layer.gameObject.SetActive (false);
	}

	void Panel4(){
		EnemyLayer.gameObject.SetActive (false);
		AntivirusLayer.gameObject.SetActive (false);
		ButtonNext.gameObject.SetActive (true);
		ButtonReverse.gameObject.SetActive (true);
		Tutor1Layer.gameObject.SetActive (false);
		Tutor2Layer.gameObject.SetActive (true);
		Tutor3Layer.gameObject.SetActive (false);
		Tutor4Layer.gameObject.SetActive (false);
		Tutor5Layer.gameObject.SetActive (false);
		Tutor6Layer.gameObject.SetActive (false);
		Tutor7Layer.gameObject.SetActive (false);
	}

	void Panel5(){
		EnemyLayer.gameObject.SetActive (false);
		AntivirusLayer.gameObject.SetActive (false);
		ButtonNext.gameObject.SetActive (true);
		ButtonReverse.gameObject.SetActive (true);
		Tutor1Layer.gameObject.SetActive (false);
		Tutor2Layer.gameObject.SetActive (false);
		Tutor3Layer.gameObject.SetActive (true);
		Tutor4Layer.gameObject.SetActive (false);
		Tutor5Layer.gameObject.SetActive (false);
		Tutor6Layer.gameObject.SetActive (false);
		Tutor7Layer.gameObject.SetActive (false);
	}

	void Panel6(){
		EnemyLayer.gameObject.SetActive (false);
		AntivirusLayer.gameObject.SetActive (false);
		ButtonNext.gameObject.SetActive (true);
		ButtonReverse.gameObject.SetActive (true);
		Tutor1Layer.gameObject.SetActive (false);
		Tutor2Layer.gameObject.SetActive (false);
		Tutor3Layer.gameObject.SetActive (false);
		Tutor4Layer.gameObject.SetActive (true);
		Tutor5Layer.gameObject.SetActive (false);
		Tutor6Layer.gameObject.SetActive (false);
		Tutor7Layer.gameObject.SetActive (false);
	}

	void Panel7(){
			EnemyLayer.gameObject.SetActive (false);
			AntivirusLayer.gameObject.SetActive (false);
			ButtonNext.gameObject.SetActive (true);
			ButtonReverse.gameObject.SetActive (true);
			Tutor1Layer.gameObject.SetActive (false);
			Tutor2Layer.gameObject.SetActive (false);
			Tutor3Layer.gameObject.SetActive (false);
			Tutor4Layer.gameObject.SetActive (false);
			Tutor5Layer.gameObject.SetActive (true);
			Tutor6Layer.gameObject.SetActive (false);
			Tutor7Layer.gameObject.SetActive (false);
		}

	void Panel8(){
		EnemyLayer.gameObject.SetActive (false);
		AntivirusLayer.gameObject.SetActive (false);
		ButtonNext.gameObject.SetActive (true);
		ButtonReverse.gameObject.SetActive (true);
		Tutor1Layer.gameObject.SetActive (false);
		Tutor2Layer.gameObject.SetActive (false);
		Tutor3Layer.gameObject.SetActive (false);
		Tutor4Layer.gameObject.SetActive (false);
		Tutor5Layer.gameObject.SetActive (false);
		Tutor6Layer.gameObject.SetActive (true);
		Tutor7Layer.gameObject.SetActive (false);
	}

	void Panel9(){
		EnemyLayer.gameObject.SetActive (false);
		AntivirusLayer.gameObject.SetActive (false);
		ButtonNext.gameObject.SetActive (false);
		ButtonExit.gameObject.SetActive (true);
		ButtonReverse.gameObject.SetActive (true);
		Tutor1Layer.gameObject.SetActive (false);
		Tutor2Layer.gameObject.SetActive (false);
		Tutor3Layer.gameObject.SetActive (false);
		Tutor4Layer.gameObject.SetActive (false);
		Tutor5Layer.gameObject.SetActive (false);
		Tutor6Layer.gameObject.SetActive (false);
		Tutor7Layer.gameObject.SetActive (true);
	}
}
