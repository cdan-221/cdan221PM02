﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene9a : MonoBehaviour
{
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
    public GameObject ArtBG1;
    public GameObject ArtBG2;
    public GameObject Choice10a;
    public GameObject Choice10b;
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
        ArtBG1.SetActive(true);
        ArtBG2.SetActive(false);
        Choice10a.SetActive(false);
        Choice10b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
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
            dialogue.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "(Mom! Mooom!)";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            Char1name.text = "YOU";
            Char1speech.text = "(P...please... hear me mom!)";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "DEMON";
            Char2speech.text = "How rude... Well...";
        }
        else if (primeInt == 5)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "DEMON";
            Char2speech.text = "Didn't your mom thought you to answer the question?";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 6)
        {
            Char1name.text = "YOU";
            Char1speech.text = "(Why I can't talk?)";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 7)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "DEMON";
            Char2speech.text = "Still being rude... Pity you.";
        }
        else if (primeInt == 8)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "DEMON";
            Char2speech.text = "We could have best friend! But, your rudeness changes everthing!";
            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice10a.SetActive(true); // function Choice1aFunct()
            Choice10b.SetActive(true); // function Choice1bFunct()
        }
        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(false);
            ArtBG2.SetActive(true);
            ArtBG1.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "Ahhh!!!";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 101)
        {
            Char1name.text = "YOU";
            Char1speech.text = "*Heavy breathing*  I am awake... \n It looked so real!";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 102)
        {
            Char1name.text = "YOU";
            Char1speech.text = "It was just a dream... I should sleep with my nightlight on.";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }

        else if (primeInt == 200)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "DEMON";
            Char2speech.text = "You hurt my feelings, very bad! \n Now now... \n You have to be punished!";
        }

        else if (primeInt == 201)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "DEMON";
            Char2speech.text = "Huh... Even your little nightlight can't save you now! \n YOU ARE MINE!";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice10aFunct()
    {
        Char1name.text = "YOU";
        Char1speech.text = "(No way! This is just my imagination! If I ... if I struggle enough, I might wake up!) \n *struggle* *struggle*";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 99;
        Choice10a.SetActive(false);
        Choice10b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice10bFunct()
    {
        Char1name.text = "YOU";
        Char1speech.text = "(There is nothing I can do...)";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 199;
        Choice10a.SetActive(false);
        Choice10b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    public void SceneChange10a()
    {
        SceneManager.LoadScene("End_Win");
    }
    public void SceneChange10b()
    {
        SceneManager.LoadScene("End_Lose");
    }
}
