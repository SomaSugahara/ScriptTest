using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss {        
	private int mp = 53;     //int型の変数mpを宣言し、53で初期化

	// mpを消費して魔法攻撃をする関数
	public void Magic(int consumption) { 
		if (mp > 4) {
			this.mp -= consumption;
			Debug.Log( "魔法攻撃をした。残りMPは" + this.mp + "。");
		} else {
			Debug.Log( "MPが足りないため魔法が使えない。");
		}
	}
}


public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// 配列を初期化する
		int[] points = {20, 40, 30, 50, 100};
		// 配列の各要素の値を順番に表示する
		for (int i = 0; i < points.Length; i++) {
			Debug.Log (points [i]);
		}
		// 配列の各要素の値を逆順に表示する
		for (int i = 4; i >= 0 ; i--) {
			Debug.Log (points [i]);
		}
		// Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss ();

		// 魔法攻撃する用の関数を呼び出す
		lastboss.Magic(5);

		for (int i = 1; i <= 10; i++) {
			if (i <= 10) {
				lastboss.Magic (5);
			}
		}
	}
		
		

	// Update is called once per frame
	void Update () {
	}
}
