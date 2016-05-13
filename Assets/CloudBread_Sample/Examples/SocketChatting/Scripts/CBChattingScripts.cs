﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class CBChattingScripts : MonoBehaviour {

	public struct ChatData
	{
		public string userName;
		public string text;

	};

	public GameObject Chatting_Panel;
	public GameObject Chatting_Cell;

	// Use this for initialization
	void Start () {

		for (int i = 0; i < 100; i++) {
//			var a = Instantiate (Chatting_Chat) as GameObject;
//
//			a.transform.SetParent (Chatting_Panel.transform, false);
			addChattingScript (new ChatData {
				userName = "hong",
				text = "Hello1"
			});
		}

//		Chatting_Panel.transform.GetComponent<RectTransform> ().rect.height = 30 * 100;

//		Text t = ContnetChatting.GetComponent<Text> ();

//		GameObject childObject = Instantiate(GameObject.Find("Chat_Panel")) as GameObject;
//
//		GameObject gb = GameObject.Find("Content");
////		var g = gb.AddComponent (typeof(CBEventsGUI));
//
//		gbb.name = "aaaa";
//		gbb.transform.parent = gb.transform;
//		text = gbb.AddComponent<Text> ();
//
//		childObject.transform.parent = gb.transform;


		GameObject childObject = Instantiate (GameObject.Find ("Chat_Panel")) as GameObject;
		GameObject parentObject = GameObject.Find ("Content") as GameObject;

//		childObject.transform.parent = parentObject.transform;
		childObject.transform.SetParent(parentObject.transform, false);

//		using (GameObject childObj = Instantiate (GameObject.Find ("Chat_Panel")) as GameObject) {
//			childObj.transform.SetParent (parentObject.transform, false);
//		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		

	public void sendButtonClicked(GameObject TextGObj){
		Text inputText = TextGObj.GetComponent<Text> () as Text;

		if (inputText.text != "") {
			addChattingScript (new ChatData {
				userName = "aaa",
				text = inputText.text
			});

//			inputText.text.Remove ();
		}
	}

	public void addChattingScript(ChatData data){
		var chatRow = Instantiate (Chatting_Cell) as GameObject;

		var nameGObj = chatRow.transform.FindChild ("Name_Text") ;
		var backgroundGObj = chatRow.transform.FindChild ("Background_Img");
		var contentGObj = backgroundGObj.transform.FindChild("Content_Text");

		nameGObj.GetComponent<Text> ().text = data.userName;
		contentGObj.GetComponent<Text> ().text = data.text;

//		nameGObj.transform.GetComponent<
//		backgroundGObj.GetComponent<RectTransform> ().sizeDelta = new Vector2 (1, 1);

		chatRow.transform.SetParent (Chatting_Panel.transform, false);

		var cellsize = Chatting_Panel.transform.GetComponent<GridLayoutGroup> ().cellSize;
		var chatContentHeight = Chatting_Panel.transform.childCount * cellsize.y;
//		print (a);

		Chatting_Panel.GetComponent<RectTransform> ().sizeDelta = new Vector2 ( 1, chatContentHeight);
//		Chatting_Panel
	}
}
