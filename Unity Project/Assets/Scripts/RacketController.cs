using UnityEngine;
using System.Collections;

public class RacketController : MonoBehaviour {
	public float speed = 1.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		MouseInputDir.flick ();	//フリック入力を受け付ける

		switch (MouseInputDir.dir) {//MouseInputDir.dirの値がどうなっているかをswitch文で判定してデバッグ表示
		case ""://入力無し
			Debug.Log ("");
			break;
		case "a"://右
			StartCoroutine("Swing",100);
			Debug.Log ("a");
			break;
		case "b"://右上
			Debug.Log ("b");
			break;
		case "c"://上
			Debug.Log ("c");
			break;
		case "d"://左上
			Debug.Log ("d");
			break;
		case "e"://左
			StartCoroutine("Swing",-100);
			Debug.Log ("e");
			break;
		case "f"://左下
			Debug.Log ("f");
			break;
		case "g"://下
			Debug.Log ("g");
			break;
		case "h"://右下
			Debug.Log ("h");
			break;
		default ://それ以外
			Debug.Log ("");
			break;
		}

		if (Input.GetKey (KeyCode.W)) {//上移動
			this.transform.position += Vector3.up * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.A)) {//左移動
			this.transform.position += Vector3.left * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.S)) {//下移動
			this.transform.position += Vector3.down * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.D)) {//右移動
			this.transform.position += Vector3.right * speed * Time.deltaTime;
		}
	}

	//オブジェクトを回転するための関数
	IEnumerator Swing(int speed){
		do {
			this.transform.RotateAround(transform.position,Vector3.up,speed*Time.deltaTime);
			yield return null;
		} while(this.transform.rotation.y > -0.50f && this.transform.rotation.y < 0.50f);
		this.transform.rotation = Quaternion.Euler (Vector3.zero);
	}
}
