using System.Collections;
using UnityEngine;

public class Tower : MonoBehaviour {
	Transform towerTransform;
	public float range;
	public GameObject bulletPrefab;
	public int cost;
	public float damage;

	public int type;

	public float fireCooldown;
	float fireCooldownLeft = 0;
	private Animator animator;

	public AudioClip _audioshot;

	// Use this for initialization
	void Start () {
		towerTransform = transform.Find ("Tower");

		//animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		//Disini
		Enemy[] enemies = GameObject.FindObjectsOfType<Enemy>();
		Enemy nearestEnemy = null;

		float jarak = Mathf.Infinity;

		foreach (Enemy e in enemies) {
			float j = Vector3.Distance (this.transform.position, e.transform.position);
			if (nearestEnemy == null || j < jarak) {
				nearestEnemy = e;
				jarak = j;
			}
		}

		if (nearestEnemy == null) {
			//Debug.Log ("Kosong");
			return;
		}

		Vector3 dir = towerTransform.transform.position - nearestEnemy.transform.position;
		towerTransform.rotation = Quaternion.AngleAxis(Mathf.Atan2 (dir.y, dir.x) * 180/ Mathf.PI,new Vector3 (0, 0, 1));
		fireCooldownLeft -= Time.deltaTime;
		if (fireCooldownLeft <= 0 && dir.magnitude <= range) {
			fireCooldownLeft = fireCooldown;
			ShootAt (nearestEnemy);
		} 
	}

	void ShootAt (Enemy e){
		AudioSource audio = GetComponent<AudioSource>();
		audio.PlayOneShot (_audioshot,0.5f);
		GameObject bulletGO = (GameObject)Instantiate (bulletPrefab, towerTransform.transform.position,this.transform.rotation);
		Bullet b = bulletGO.GetComponent <Bullet> ();
		b.target = e.transform;
		b.damage = damage;
		b.range = range;

	}


}
