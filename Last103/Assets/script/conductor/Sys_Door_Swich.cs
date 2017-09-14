using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sys_Door_Swich : MonoBehaviour {

	[Header("電源")]
	public bool flag_Power;
	[Header("電源ON")]
	public GameObject button_Power_On;
	[Header("電源OFF")]
	public GameObject button_Power_Off;
	[Header("ドア")]
	public bool flag_Door;
	[Header("ドア開")]
	public GameObject button_Door_Open;
	private Image Door_Open_Now;
	public Image Door_Open_UP;
	public Image Door_Open_Down;
	[Header("ドア閉")]
	public GameObject button_Door_Close;
	private Image Door_Cloase_Now;
	public Image Door_Cloase_Up;
	public Image Door_Cloase_Down;
	[Header("ドア右")]
	public GameObject Door_Right_OBJ;
	[Header("ドア左")]
	public GameObject Door_Left_OBJ;
	[Header("ドア速度")]
	public float Door_Speed;
	[Header("ドア右限界")]
	public float Door_right_Limit;
	[Header("ドア左限界")]
	public float Door_Left_Limit;
	[Header("ドア右中限界")]
	public float Door_right_Center_Limit;
	[Header("ドア左中限界")]
	public float Door_Left_Center_Limit;
	// Use this for initialization
	void Start () {
		//スイッチ
		button_Door_Open = GameObject.Find ("Button_Open");
		button_Door_Close = GameObject.Find ("Button_Close");
		Door_Open_Now = button_Door_Open.GetComponent<Image> ();
		Door_Cloase_Now = button_Door_Close.GetComponent<Image> ();
		//ドア
		Door_Left_OBJ = GameObject.Find (" Door_Left");
		Door_Right_OBJ = GameObject.Find (" Door_Right");

		SysCheck ();
	}
	
	// Update is called once per frame
	void Update () {
		MoveLeftDoor ();
		MoveRightDoor ();
	}
	//電源系
	public void Swich_ON()
	{
		flag_Power = true;
	}
	public void Swich_OFF()
	{
		flag_Power = false;	
	}
	//ドア系
	public void Door_Open()
	{
		if (flag_Power == true) {
			flag_Door = true;

			Door_Open_Now.sprite = Door_Open_Down.sprite;
			Door_Cloase_Now.sprite = Door_Cloase_Down.sprite;
		}
	}
	public void Door_Close()
	{
		if (flag_Power == true) {
			flag_Door = false;

			Door_Open_Now.sprite = Door_Open_UP.sprite;
			Door_Cloase_Now.sprite = Door_Cloase_Up.sprite;

		}
	}
	//排他的制御
	private void SysCheck()
	{
		if (flag_Door == false) {
			Door_Open_Now.sprite = Door_Open_UP.sprite;
			Door_Cloase_Now.sprite = Door_Cloase_Up.sprite;
		}
	}
	//移動
	public void MoveLeftDoor()
	{
		if (flag_Door == true) {
			if (Door_Left_OBJ.transform.position.x < Door_Left_Center_Limit) {
				Door_Left_OBJ.transform.position = new Vector3 (Door_Left_OBJ.transform.position.x + Door_Speed,Door_Left_OBJ.transform.position.y,Door_Left_OBJ.transform.position.z);
			}
		} else {
			if (Door_Left_OBJ.transform.position.x > Door_Left_Limit) {
				Door_Left_OBJ.transform.position = new Vector3 (Door_Left_OBJ.transform.position.x - Door_Speed,Door_Left_OBJ.transform.position.y,Door_Left_OBJ.transform.position.z);
			}
		}
	}
	public void MoveRightDoor()
	{
		if (flag_Door == true) {
			if (Door_Right_OBJ.transform.position.x > Door_right_Center_Limit) {
				Door_Right_OBJ.transform.position = new Vector3 (Door_Right_OBJ.transform.position.x - Door_Speed,Door_Right_OBJ.transform.position.y,Door_Right_OBJ.transform.position.z);
			}
		} else {
			if (Door_Right_OBJ.transform.position.x < Door_right_Limit) {
				Door_Right_OBJ.transform.position = new Vector3 (Door_Right_OBJ.transform.position.x + Door_Speed,Door_Right_OBJ.transform.position.y,Door_Right_OBJ.transform.position.z);
			}
		}
	}
}
