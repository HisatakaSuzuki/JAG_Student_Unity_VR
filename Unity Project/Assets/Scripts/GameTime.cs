using UnityEngine;
using System.Collections;
using UnityEngine.UI;	//UIを使うときに必要

public class GameTime : MonoBehaviour {
	public Text text;	//UIのテキストを扱う
	float time;			//経過時間を保持

	// Use this for initialization
	void Start () {
		time = 0.0f;	//経過時間を初期化
		text.text = time.ToString();	//UIのテキストに時間の変数を表示する
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;	//時間を更新
		text.text = time.ToString();	//UIのテキストに時間の変数を表示する
	}
}