using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene5 : MonoBehaviour
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
        ArtChar2.SetActive(false);
        ArtChar3.SetActive(false);
        ArtChar4.SetActive(false);
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
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            dialogue.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "Hey, Jimmy, are you still there?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "JIMMY";
            Char2speech.text = "Yea I'm here.";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Lets play a couple more games.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 5)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "JIMMY";
            Char2speech.text = "I thought you had to sleep.";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 6)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Nah, can’t sleep, just going to stay up a little bit longer";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 7)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "JIMMY";
            Char2speech.text = "Doesn’t your mom get mad for staying up too long?";
        }
        else if (primeInt == 8)
        {
            Char1name.text = "YOU";
            Char1speech.text = "If i’m quiet i won’t get caught.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 9)
        {       
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "JIMMY";
            Char2speech.text = "Are you sure you wanna risk it?";
        }
        else if (primeInt == 10) 
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(true);
            ArtChar4.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "JIMMY";
            Char2speech.text = "Your mom is terrifying when she catches you, she's like a demon.";
        }
        else if (primeInt == 11)
        { 
            Char1name.text = "YOU";
            Char1speech.text = "Aren't you the one who convinced me to play?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 12)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "JIMMY";
            Char2speech.text = "Yea but now I kinda have a bad feeling about this.";
            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
        }
        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(true);
            ArtChar4.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "JIMMY";
            Char2speech.text = "Don't blame me if you get caught.";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }
        else if (primeInt == 101)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }

        else if (primeInt == 200)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "JIMMY";
            Char2speech.text = "Alright, cya man.";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }
        else if (primeInt == 201)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct()
    {
        Char1name.text = "YOU";
        Char1speech.text = "Don't be such a killjoy, shut up and play.";
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
        Char1name.text = "YOU";
        Char1speech.text = "You know what, you're right. I should probably go.";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 199;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    public void SceneChangeLose()
    {
        SceneManager.LoadScene("Scene5Lose");
    }
    public void SceneChange6()
    {
        SceneManager.LoadScene("Scene6");
    }

}
