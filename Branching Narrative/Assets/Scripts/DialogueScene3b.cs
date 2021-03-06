﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene3b : MonoBehaviour
{
    public string playerName;
	public DialogueGameHandler gameHandler;

    public int primeInt = 1; // This integer drives game progress!
    public Text Char1name;
    public Text Char1speech;
    public Text Char2name;
    public Text Char2speech;
    public Text Char3name;
    public Text Char3speech;
    public GameObject dialogue;
    public GameObject ArtChar1;
    public GameObject ArtChar2;
    public GameObject ArtChar3;
    public GameObject ArtBG1;
    public GameObject Choice1a;
    public GameObject Choice1b;
    public GameObject NextScene1Button;
    public GameObject NextScene2Button;
    public GameObject nextButton;
    //public GameObject gameHandler;
    //public AudioSource audioSource;
    private bool allowSpace = true;

    void Start()
    {         // initial visibility settings
        dialogue.SetActive(false);
        ArtChar1.SetActive(false);
        ArtChar2.SetActive(false);
        ArtChar3.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);

	    string playerNameTemp = gameHandler.GetName();
	    playerName = playerNameTemp.ToUpper();
    }

    void Update()
    {         // use spacebar as Next button
        if (allowSpace == true)
        {
            if (Input.GetKeyDown("space"))
            {
                talking();
            }
        }
    }

    public void talking()
    {         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1)
        {
            // AudioSource.Play();
        }
        else if (primeInt == 2)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            dialogue.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "JIMMY";
            StartCoroutine(TypeText(Char2speech, "Hey, man... It's been 2 hours and you still haven't picked a game! " ));
        }
        else if (primeInt == 3)
        {
            Char1name.text = playerName;
            StartCoroutine(TypeText(Char1speech, "...Give me a minute. I will find one! " ));
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "JIMMY";
            StartCoroutine(TypeText(Char2speech, "Umm... It is okay bro. If you stay more, you won't get enough sleep. " ));
        }
        else if (primeInt == 5)
        {
            Char1name.text = playerName;
            StartCoroutine(TypeText(Char1speech, "... " ));
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 6)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            Char1name.text = playerName;
            StartCoroutine(TypeText(Char1speech, "Maybe... Yeah, you are right Jimmy! " ));
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 7)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "JIMMY";
            StartCoroutine(TypeText(Char2speech, "Don't worry, we can play later! " ));
        }
        else if (primeInt == 8)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(true);
            StartCoroutine(FadeIn(ArtChar3));
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "MOM";
            Char2speech.text = "Honey, can you bring me the flash light from basement?";
        }
        else if (primeInt == 9)
        {
            Char1name.text = playerName;
            Char1speech.text = "But I really need to sleep, mom.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 10)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "MOM";
            Char2speech.text = "Honey, it won't take too long!";


            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
        }
        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "MOM";
            Char2speech.text = "Thank you, honey!";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }
        else if (primeInt == 200)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "MOM";
            Char2speech.text = "It's okay, honey. I will get it by myself.";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct()
    {
        Char1name.text = playerName;
        Char1speech.text = "*Sigh* Okay mom...";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 99;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice1bFunct()
    {
        Char1name.text = playerName;
        Char1speech.text = "I'm sorry mom, but I really have to sleep...";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 199;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    public void SceneChange2a()
    {
        SceneManager.LoadScene("Scene4c");
    }
    public void SceneChange2b()
    {
        SceneManager.LoadScene("Scene3");
    }
    IEnumerator FadeIn(GameObject fadeImage)
    {
        float alphaLevel = 0;
        fadeImage.GetComponent<Image>().color = new Color(1, 1, 1, alphaLevel);
        for (int i = 0; i < 100; i++)
        {
            alphaLevel += 0.01f;
            yield return null;
            fadeImage.GetComponent<Image>().color = new Color(1, 1, 1, alphaLevel);
            Debug.Log("Alpha is: " + alphaLevel);
        }
    }

    IEnumerator FadeOut(GameObject fadeImage)
    {
        float alphaLevel = 1;
        fadeImage.GetComponent<Image>().color = new Color(1, 1, 1, alphaLevel);
        for (int i = 0; i < 100; i++)
        {
            alphaLevel -= 0.01f;
            yield return null;
            fadeImage.GetComponent<Image>().color = new Color(1, 1, 1, alphaLevel);
            Debug.Log("Alpha is: " + alphaLevel);
        }
    }
    IEnumerator TypeText(Text target, string fullText)
    {
        float delay = 0.02f;
        nextButton.SetActive(false);
        allowSpace = false;
        for (int i = 0; i < fullText.Length; i++)
        {
            string currentText = fullText.Substring(0, i);
            target.text = currentText;
            yield return new WaitForSeconds(delay);
        }
        nextButton.SetActive(true);
        allowSpace = true;
    }
}