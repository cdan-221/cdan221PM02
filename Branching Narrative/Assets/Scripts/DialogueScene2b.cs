using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene2b : MonoBehaviour
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
    public GameObject ArtBG1;
    public GameObject Choice3;
    public GameObject Choice6;
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
        Choice3.SetActive(false);
        Choice6.SetActive(false);
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
            ArtChar2.SetActive(true);
            ArtChar3.SetActive(false);
            dialogue.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "JIMMY";
            Char2speech.text = "Alrighty!! Time to play some games!";
        }
        else if (primeInt == 3)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Hey, the Jimster05!! ;)";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "JIMMY";
            Char2speech.text = "Just call me Jimmy...";
        }
        else if (primeInt == 5)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Let's play couple games of Anti-Attack!";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 6)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            ArtChar3.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "JIMMY";
            Char2speech.text = "Ye, let's do it!";
        }
        else if (primeInt == 7)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Haven’t play in a while, go easy on me...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 8)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "JIMMY";
            Char2speech.text = "Bruh, you pull your weight, I ain’t gonna carry your *ss!";
        }
        else if (primeInt == 9)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            ArtChar3.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "**A couple games later** I'm done with this games...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 10)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "JIMMY";
            Char2speech.text = "Do you wanna play different game??";
        }
        else if (primeInt == 11)
        {
            Char1name.text = "YOU";
            Char1speech.text = "I'm not sure, I got work tomorrow morning.";
            Char2name.text = "";
            Char2speech.text = "";
            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice3.SetActive(true); // function Choice1aFunct()
            Choice6.SetActive(true); // function Choice1bFunct()
        }
        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Bed, here I come!";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 200)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "JIMMY";
            Char2speech.text = "There we go! There is a lot of choices!!";
        }
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice3Funct()
    {
        ArtChar1.SetActive(false);
        ArtChar2.SetActive(true);
        ArtChar3.SetActive(false);
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "JIMMY";
        Char2speech.text = "I should go to bed, Jimmy. Cya!";
        primeInt = 99;
        Choice3.SetActive(false);
        Choice6.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice6Funct()
    {
        ArtChar1.SetActive(false);
        ArtChar2.SetActive(true);
        ArtChar3.SetActive(false);
        Char1name.text = "YOU";
        Char1speech.text = "...Okay! Let's do few more rounds in different game!!";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 199;
        Choice3.SetActive(false);
        Choice6.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    public void SceneChange3()
    {
        SceneManager.LoadScene("Scene3");
    }
    public void SceneChange6()
    {
        SceneManager.LoadScene("Scene6");
    }
}