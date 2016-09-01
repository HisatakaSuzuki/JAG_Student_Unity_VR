using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	public float speed = 0.5f;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody> ().AddForce ((transform.forward + transform.right + transform.up) * speed,	ForceMode.VelocityChange);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//オブジェクト同士が衝突したときに呼ばれる関数
	void OnCollisionEnter(Collision obj){
		if (obj.gameObject.tag == "GameOver") {//ぶつかった相手のタグを確認
			GameObject.Instantiate (this.gameObject, new Vector3 (0, 3, 0), Quaternion.identity);//新しく生成
			Destroy (this.gameObject);	//自身を破棄
		}
	}
}
