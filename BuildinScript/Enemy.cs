using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {
	private GameObject[] getCount;
	private string getString;
	private int count;
	public int alpa;
	public int beta;
	public int identity = 1;
	public int arena;
	public int deathPoin = 10;
	public int spawned;

	public static int intSpawn;
	GameObject pathGO;
	Transform targetPathNode;
	int pathNodeIndex = 0;
	public float speed;

	public float health;
	public Animator animator;
	public int getMoney;



	// Use this for initialization
	void Start () {
		
		animator = GetComponent<Animator> ();
		if (arena == 1) {
			pathGO = GameObject.Find ("Path");
		} else if (arena == 2) {
			pathGO = GameObject.Find ("Path");
		} else if (arena == 3) {
			pathGO = GameObject.Find ("Path1");
		} else if (arena == 4) {
			pathGO = GameObject.Find ("Path2");
		}
			 

		//Mencari gameobject berupa titik path
		//Mencari komponen gameobject berupa animator
	}

	void GetNextPathNodeLevel(){
		if(pathNodeIndex < pathGO.transform.childCount) {
			targetPathNode = pathGO.transform.GetChild(pathNodeIndex);
			pathNodeIndex++;

		}
		//Menghitung titik path
	}
	//Untuk level 1


	//======================================================================================//

	// Update is called once per frame
	void Update () {
		move ();
	}
	/// <summary>
	/// untuk memanggil fungsi dalam tiap level
	/// </summary>
	void move(){
		
		if (targetPathNode == null) {
			GetNextPathNodeLevel ();
			if (targetPathNode == null) {
				ReachedGoal();

				return;
			}

		}
		Vector3 dir = targetPathNode.position - this.transform.localPosition;
		float distThisFrame = speed * Time.deltaTime;
		if (dir.magnitude <= distThisFrame) {
			//Sampai ke node baru
			targetPathNode = null;

		} else {
			//Pindeh ke node baru
			transform.Translate (dir.normalized * distThisFrame);
			//Debug.Log (pathNodeIndex);
			if (arena == 1) {
				level1 ();
			} else if (arena == 2) {
				level2 ();
			} else if (arena == 3) {
				level3 ();
			} else if (arena == 4) {
				level4 ();
			}
				
		}
	
	}

	//fungsi untuk arena 2
	void level1(){
		if (pathNodeIndex == 3) {
			animator.SetInteger ("status", 3);
		} else if (pathNodeIndex == 4) {
			animator.SetInteger ("status", 4);
		} else if (pathNodeIndex == 5) {
			animator.SetInteger ("status", 5);
		} else if (pathNodeIndex == 6) {
			animator.SetInteger ("status", 6);
		}
	}

	void level2(){
		if (pathNodeIndex == 2) {
			animator.SetInteger ("status", 2);
		} else if (pathNodeIndex == 3) {
			animator.SetInteger ("status", 3);
		}
	}

	void level3(){
		if (pathNodeIndex == 2) {
			animator.SetInteger ("status", 2);
		} else if (pathNodeIndex == 3) {
			animator.SetInteger ("status", 3);
		}
	}

	void level4(){
		if (pathNodeIndex == 2) {
			animator.SetInteger ("status", 2);
		} else if (pathNodeIndex == 3) {
			animator.SetInteger ("status", 3);
		}
	}


	//=========================================================================================//

	public void ReachedGoal(){
		GameObject.FindObjectOfType<ScoreManager> ().MinusLife ();
		int sm = GameObject.FindObjectOfType<ScoreManager>().level;
		if (sm == 1) {
			int count;
			GameObject[] gos;
			gos = GameObject.FindGameObjectsWithTag ("Enemy");
			count = gos.Length;
			intSpawn = count--;
			if (count == 0) {
				Debug.Log (count + "horeee");
				GameObject.FindObjectOfType<ScoreManager> ().WinOver ();
			}
		} else if(sm == 2) {
			int count;
			GameObject[] gos;
			gos = GameObject.FindGameObjectsWithTag ("Enemy");
			count = gos.Length;
			if (count <= 1) {
				Debug.Log (count + "Ini sisa");
				Debug.Log ("ini sisa 0 atau 1");
				GameObject.FindObjectOfType<ScoreManager> ().WinOver ();
			}
		}

		Destroy (gameObject);
	}
		
	public void TakeDamage(float damage) {
		health -= damage;
		if(health <= 0) {
			Die();

		}

	}

	public void Die(){
		GameObject.FindObjectOfType<ScoreManager> ().coin += getMoney;
		GameObject.FindObjectOfType<BuildManager> ().deathScore += deathPoin;
		int en = GameObject.FindObjectOfType<Enemy> ().GetComponent<Enemy> ().identity;
		//=============================================================================//
		getCount = GameObject.FindGameObjectsWithTag ("Enemy");
		count = getCount.Length;
		alpa = count - en;
		Debug.Log (count + "mati");
		GameObject.FindObjectOfType<ScoreManager> ().diedEnemy += en;
		if (alpa == 0) {
			Debug.Log ("horeee");
			GameObject.FindObjectOfType<ScoreManager> ().WinOver ();
		}

		Destroy (gameObject);
	}


		
}
