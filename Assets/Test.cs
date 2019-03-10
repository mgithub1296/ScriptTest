using UnityEngine;
using System.Collections;

public class Boss {  
	//int型の変数mpを宣言し、53で初期化してください
	private int mp = 53;

	//mpを消費して魔法攻撃をするMagic関数を作ってください
	public void Magic() { 
		//Magic関数内でmpを5減らし、コンソールに「魔法攻撃をした。残りMPは〇〇。」と表示してください。mpが足りない場合、「MPが足りないため魔法が使えない。」と表示してください
		if (this.mp > 4) {
			this.mp -= 5;
			Debug.Log ("魔法攻撃をした。残りMPは" + this.mp + "。");
		} else {
			Debug.Log ("MPが足りないため魔法が使えない。");
		}
	}
}

public class Test : MonoBehaviour {

	void Start () {
		// 要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください
		int[] array = {30, 20, 50, 10, 80};

		// for文を使い、配列の各要素の値を順番に表示してください
		for (int i = 0; i < array.Length; i++) {
			Debug.Log (array [i]);
		}

		//for文を使い、配列の各要素の値を逆順に表示してください
		//疑問：array.Length使えないの？
		for (int i = 4; i > -1; i--) {
			Debug.Log (array [i]);
		}


		// Bossクラスの変数を宣言してインスタンスを代入
		Boss midboss = new Boss ();

		// Magic関数を呼び出して、魔法を使ってください
		midboss.Magic();
		// Magic関数を10回使った後に、更にMagic関数を呼び出すと、mpが足りないメッセージが表示されることを確認してください
		midboss.Magic();
		midboss.Magic();
		midboss.Magic();
		midboss.Magic();
		midboss.Magic();
		midboss.Magic();
		midboss.Magic();
		midboss.Magic();
		midboss.Magic();
		midboss.Magic();
	}

	// Update is called once per frame
	void Update () {

	}
}