using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buleetScript : MonoBehaviour {

	public GameObject ink;//生成するinkオブジェクト


	// ぶつかった時に呼び出される関数
	void OnCollisionEnter (Collision col)
	{


		ContactPoint contact = col.contacts[0];//ぶつかったポイントの情報を取得

		// contact.nomalとは、ぶつかった場所に対して垂直なベクトル
		Vector3 position = contact.point + contact.normal * 0.01f;//生成するポジション

		GameObject obj = Instantiate (ink, position, transform.rotation) as GameObject;
		obj.transform.forward = contact.normal; // インクの向きをぶつかったものに対して垂直に配置する

		Destroy(this.gameObject); //bulletを消す
	}
}




























