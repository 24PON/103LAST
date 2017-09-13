using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sys_direction_UP : MonoBehaviour {
	[Header("方向幕オブジェクト")]
	public RectTransform direction_OBJ;
	[Header("上限")]
	public float max_UP_Direction;
	[Header("下限")]
	public float max_Down_Direction;
	[Header("速度")]
	public float direction_Speed;
	//押しっぱなし
	public bool push = false;
	// Use this for initialization
	void Start () {
		direction_OBJ = GameObject.Find ("Direction").GetComponent<RectTransform>();

	}

	// Update is called once per frame
	void Update () {
		UpDirection ();
	}
	//押しっぱなし用
	public void PushDown(){
		push = true;
	}

	public void PushUp(){
		push = false;
	}

	//アップ
	public void UpDirection()
	{
		if(push){
			if (direction_OBJ.transform.localPosition.y < max_UP_Direction) {
				direction_OBJ.transform.position = new Vector3 (direction_OBJ.transform.position.x, direction_OBJ.transform.position.y + direction_Speed, direction_OBJ.transform.position.z);
			}
		}
	}
}
