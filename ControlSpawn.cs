using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSpawn : MonoBehaviour {
	
	public GameObject EnemyA1;
	public GameObject EnemyA2;
	public GameObject EnemyB1;
	public GameObject EnemyB2;
	List<string> rndlokasi = new List<string>();

	// Use this for initialization
	void Start () {
		startRandom();
		
	}
	
	// Update is called once per frame
	void Update () {
		

	}

	void startRandom(){
		List<string> alpa = new List<string>{ "1", "2", "3", "4" };
		rndlokasi.Clear ();
		for (int i = 0; i < 4; i++) {
			
			int  r = Random.Range (0, alpa.Count);
			//Debug.Log ("random " + r + " Count "+ alpa.Count);
			rndlokasi.Add( alpa [r]);
			alpa.Remove (alpa [r]);
			}
		for (int i = 0; i < rndlokasi.Count; i++) {
			//Debug.Log (rndlokasi [i]);
			}	
		}
	}
	

