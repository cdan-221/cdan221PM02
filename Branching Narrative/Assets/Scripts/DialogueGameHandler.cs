using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueGameHandler : MonoBehaviour
{

	public static string playerName = "YOU";

    public static int playerStat;
    //public GameObject textGameObject;

    //voidÂ Start () { UpdateScore (); }

    void Update()
    {                // Remove this function when PauseMenu is added
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    public void AddPlayerStat(int amount)
    {
        playerStat += amount;
        Debug.Log("Current Player Stat = " + playerStat);
        //      UpdateScore ();
    }

    //voidÂ UpdateScore () {
    //        TextÂ scoreTextB = textGameObject.GetComponent ();
    //        scoreTextB.text =Â "Score: "Â + score; }

    public void RestartGame()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

	public void UpdateName(string newName){
		playerName = newName;
		Debug.Log("name changed to " + playerName);
	}

	public string GetName(){
		return playerName;
	}

}