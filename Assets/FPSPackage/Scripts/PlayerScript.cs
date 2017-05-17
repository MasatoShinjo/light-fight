using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript: MonoBehaviour {

	public int playerHP = 3; 
	public Text HPLabel;

	// ゲームの1フレームごとに呼ばれるメソッド
	void Update () {

		HPLabel.text = "PlayerHP:" + playerHP.ToString ();

		if (playerHP <= 0) {

			SceneManager.LoadScene ("GameOver");
		}
	}

	// ダメージを与えられた時に行いたい命令を書く
	void Damage(){
		playerHP--;
		if (playerHP <= 0) {
			SceneManager.LoadScene ("GameOver");
		}
	}
	void OnTriggerEnter(Collider other){

		if (other.gameObject.tag == "Enemy") {

			playerHP--;
			Destroy (other.gameObject);

		} else if (other.gameObject.tag == "Treasure") {

			SceneManager.LoadScene ("GameClear");
		}


	}

}

