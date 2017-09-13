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
	[Header("ドア閉")]
	public GameObject button_Door_Close;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
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
		}
	}
	public void Door_Close()
	{
		if (flag_Power == true) {
			flag_Door = false;
		}
	}
	//排他的制御
	private void SysCheck()
	{
		
	}
}
