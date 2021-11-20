using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class math : MonoBehaviour {

	public Dropdown DropDownA;
	float[] iA = {20f,30f,40f};
	public Dropdown DropDownB;
	float[] iB = {40f,60f,80f};
	public Dropdown DropDown_cm;
	string[] s_cm = {"3","6","9"};
	public Text InputField_kg;
	string[] IF_kg={"1.2","0.6","0.4"};

	public Text Text_result;
	string[] result={"2/1","3/1","4/1","4/3","8/3","1/1","3/2"};

	public Text TextA;
	public Text TextB;
	public Text Text_cm;
	public Text Text_kg;
	public Text Text_BA;

	public Animator SV;


	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () 
	{
		//print ("齒輪A："+DropDownA.value+"，齒輪B："+DropDownB.value+"，軸長："+DropDown_cm.value+"，施力大小："+DropDown_kg.value);
	}


	public void OnClick()
	{
		//print ("齒輪A："+DropDownA.value+"，齒輪B："+DropDownB.value+"，軸長："+DropDown_cm.value+"，施力大小："+DropDown_kg.value);
		TextA.text = TextA.text + iA [DropDownA.value].ToString();
		TextB.text = TextB.text + iB [DropDownB.value].ToString();
		Text_cm.text = Text_cm.text+ s_cm [DropDown_cm.value];
		Text_kg.text = Text_kg.text + IF_kg [DropDown_cm.value];
		string D= (iB [DropDownB.value] / iA [DropDownA.value]).ToString ("F");

		if (D == "2.00") {
			Text_result.text =result [0].ToString ();
			Text_BA.text = Text_BA.text + result [0].ToString ();
		}
		
		if (D == "3.00") {
			Text_result.text =result [1].ToString ();
			Text_BA.text = Text_BA.text + result [1].ToString ();
		}

		if (D == "4.00") {
			Text_result.text =result [2].ToString ();
			Text_BA.text = Text_BA.text + result [2].ToString ();
		}

		if (D== "1.33") {
			Text_result.text = result [3].ToString ();
			Text_BA.text = Text_BA.text + result [3].ToString ();
		}

		if (D == "2.67") {
			Text_result.text = result [4].ToString ();
			Text_BA.text = Text_BA.text + result [4].ToString ();
		}

		if (D == "1.00") {
			Text_result.text = result [5].ToString ();
			Text_BA.text = Text_BA.text + result [5].ToString ();

		}

		if (D == "1.50") {
			Text_result.text =result [6].ToString ();
			Text_BA.text = Text_BA.text + result [6].ToString ();
		}
	}

	public void InputF_kg()
	{
		InputField_kg.text = IF_kg [DropDown_cm.value];
	}

	public void OnClick_B()
	{
		SV.SetBool ("click_d",true);
		StartCoroutine ("SetTime");
	}

	IEnumerator	SetTime(){

		yield return new WaitForSeconds (1);
		SV.SetBool ("click_d",false);
		SV.enabled = false;
	}
}
