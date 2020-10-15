
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class NameTransfer : MonoBehaviour {

        public string theName;
        public GameObject inputField;
        public GameObject textDisplay;
	public GameObject welcomeDisplay;
	public DialogueGameHandler gameHandler;

	public void Start(){
		welcomeDisplay.SetActive(false);
	}


        public void StoreName(){
                theName = inputField.GetComponentInChildren<Text>().text;
                textDisplay.GetComponent<Text>().text = "Welcome, " + theName + ", to the game.";
		welcomeDisplay.SetActive(true);
		gameHandler.UpdateName(theName);
        }
}