using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour {
	public float speed = 1f;
	public Transform target;
	public float damage = 2f;
	public float range;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(target == null) {
			// Our enemy went away!
			Destroy(gameObject);
			return;
		}
			
		Vector3 dir = target.position - this.transform.localPosition;
		float distThisFrame = speed * Time.deltaTime;
		//Mengetahui jarak dan arah dari musuh
		if (dir.magnitude <= distThisFrame) {
			BulletHit();
			//Jika arah lebih dekat dengan jarak maka fungsi tembak dilakukan
		} else {
			transform.Translate (dir.normalized * distThisFrame);
			//Jika tidak fungsi tembak tidak dijalankan dan tower cuma berputar
		}
	}

	void BulletHit(){
		target.GetComponent<Enemy>().TakeDamage(damage);
		Destroy (gameObject);
		//Fungsi tembak
	}
}
