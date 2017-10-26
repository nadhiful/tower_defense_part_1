using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour {
	
	float spawncoolDown = 0.5f;
	float cooldownRemain = 3f;

	/// <summary>
	/// The count wave.
	/// </summary>
	public int countWave;
	private int getArena;
	private int beta;
	public int random;
	public static bool lastWave;
	public Text batchText;

	/// <summary>
	/// Batch member.
	/// </summary>
	/// 

	[System.Serializable]
	public class BatchMember{
		public GameObject enemyPrefabs;
		public int num;
		public Transform location;
		[System.NonSerialized]
		public int spawned = 0;
	}

	public BatchMember[] batch;


	// Use this for initialization
	void Awake(){
		
	}
	void Start () {
		
	}
		
	// Update is called once per frame
	void Update ()
	{
		ScoreManager sm = GameObject.FindObjectOfType<ScoreManager> ();
		//Mengecek variabel level
		if (sm.level == 1) {
			level1 ();
		} else if (sm.level == 2) {
			randomExit ();
		} else if (sm.level == 3) {
			randomExit ();
		}
	}

	//Fungsi Spawn Level 1
	void level1(){
		cooldownRemain -= Time.deltaTime; //Hitung mundur timer
		if (cooldownRemain < 0) {
			
			bool isSpawned = false;
			cooldownRemain = spawncoolDown; // Waktu cooldown untuk objek

			foreach (BatchMember bm in batch) {

				if (bm.spawned < bm.num) {
					bm.spawned++;
					Instantiate (bm.enemyPrefabs, this.transform.position, this.transform.rotation); //Instantiate objek
					isSpawned = true;
					break;
				}
				//Spawn batch 1;
			}

			if(isSpawned == false) {

				if(transform.parent.childCount > 1) { //Pengecekan banyaknya child
					transform.parent.GetChild (1).gameObject.SetActive (true); //Set aktif child yang pertama(teratas)
					countWave = transform.parent.childCount; //Menghitung banyaknya child
					//Debug.Log (countWave);
					ScoreManager sm = GameObject.FindObjectOfType<ScoreManager> (); //Mengambil referensi variable dari gameobject ScoreManager
					sm.wave = 1; //Mengambil variable wave
					int beta = countWave - sm.wave; //Inisiasi variabel dengan nilai countwave - sm.wave
					batchText.text = beta.ToString (); //Memasukkan nilai ke dalam objek yang berupa text
					//Debug.Log (beta);
					Debug.Log ("tes");
				}else{

					batchText.text = "0"; //Menset nilai 0
				}
				Destroy(gameObject);
			}
		}
	}

	//Fungsi Spawn Level 2
	void randomExit(){
		//RandomInt ();
		cooldownRemain -= Time.deltaTime; //Hitung mundur timer
		if (cooldownRemain < 0) {
			bool isSpawned = false;
			cooldownRemain = spawncoolDown; // Waktu cooldown untuk objek
				foreach (BatchMember bm in batch) {
					if (bm.spawned < bm.num) {
					bm.spawned++;
					Instantiate (bm.enemyPrefabs, this.transform.position, this.transform.rotation);  //Instantiate objek
					isSpawned = true;
					break;
					}
					//Spawn batch 2;
				}

			if(isSpawned == false) {
				
				if (transform.parent.childCount > 1) {//Pengecekan banyaknya child
					RandomPath (); //Menjalankan fungsi randomPath
					countWave = transform.parent.childCount; //Menghitung banyaknya child
					ScoreManager sm = GameObject.FindObjectOfType<ScoreManager> (); //Mengambil referensi variable dari gameobject ScoreManager
					sm.wave = 1; //Mengambil variable wave
					int beta = countWave - sm.wave; //Inisiasi variabel dengan nilai countwave - sm.wave
					batchText.text = beta.ToString (); //Memasukkan nilai ke dalam objek yang berupa text

				} else{
					batchText.text = "0";
				}

				Destroy(gameObject); //Menghancurkan gameObject
			}
		}

	}

	void RandomPath(){
		int childCount = transform.parent.childCount;//Menghitung banyaknya child dari sebuah parent
		int r = Random.Range (1, childCount - 1);//Mengacak angka dengan batasan,minimum = 1,maksimum nilai childcount - 1;

		if (r <= 1) { //Pengecekan apakah nilai yang dihasilkan oleh random <= 1
			//Bila iya maka mengaktifkan child teratas dari sebuah parent yaitu child dengan index 1
			transform.parent.GetChild (1).gameObject.SetActive (true);
		} else {
			//Bila tidak,maka akan diset nilai dari hasil random sebagai nilai index ke 1
			transform.parent.GetChild (r).SetSiblingIndex (1);
			//Kemudiana mengaktifkan child dengan index satu(child teratas)
			transform.parent.GetChild (1).gameObject.SetActive (true);

		}		
	}

	//		Debug.Log ("random " + r);
	//		Debug.Log ("ini childCount " + childCount);
	//		transform.parent.GetChild (1).gameObject.SetActive (true);

}



