using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene6 : MonoBehaviour
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
    public GameObject ArtChar3;
    public GameObject ArtChar4;
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
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
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
            dialogue.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "You were right Jimmy, a few more games wouldn't hurt!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 3)
        {
            ArtChar3.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "JIMMY";
            Char2speech.text = "Right? More fun doesn't hurt anybody!";
            Char3name.text = "";
            Char3speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Ok, lets keep going then!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 5)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "JIMMY";
            Char2speech.text = "Sure thing!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 6)
        {
            ArtChar3.SetActive(false);
            ArtChar1.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "MOM";
            Char3speech.text = "Huh?! You're still awake?";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 6)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Oh no, that's my mom she found out.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 7)
        {
            ArtChar1.SetActive(false);
            ArtChar4.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "JIMMY";
            Char2speech.text = "I told you if you get caught it isnt my fault, you're on your own buddy.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 8)
        {
            ArtChar4.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "Huh? How you going to run from this??";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
            else if (primeInt == 9)
            {
                ArtChar2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "MOM";
                Char3speech.text = "GO TO BED!";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
        }
        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
            ArtChar2.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "No, I don't want to!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }

        else if (primeInt == 200)
        {
            ArtChar2.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "Yes, mom...";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice6aFunct()
    {
        
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "MOM";
        Char2speech.text = "*WHACK*";
        Char3name.text = "";
        Char3speech.text = "";
        primeInt = 99;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
        
    }
    public void Choice6bFunct()
    {
        Char1name.text = "YOU";
        Char1speech.text = "*Sigh*";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
        primeInt = 199;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    public void SceneChangeEnd_KOd()
    {
        SceneManager.LoadScene("End_KOd");
    }
    public void SceneChange7()
    {
        SceneManager.LoadScene("Scene7");
    }
}