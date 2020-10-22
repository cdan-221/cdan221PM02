using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene7 : MonoBehaviour
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
    public GameObject ArtBG1;
    public GameObject Choice8a;
    public GameObject Choice8b;
    public GameObject Choice8c;
    public GameObject NextScene1Button;
    public GameObject NextScene2Button;
    public GameObject NextScene3Button;
    public GameObject nextButton;
    //public GameObject gameHandler;
    //public AudioSource audioSource;
    private bool allowSpace = true;

    void Start()
    {         // initial visibility settings
        dialogue.SetActive(false);
        ArtChar1.SetActive(false);
        ArtBG1.SetActive(true);
        Choice8a.SetActive(false);
        Choice8b.SetActive(false);
        Choice8c.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        NextScene3Button.SetActive(false);
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
            dialogue.SetActive(true);
            Char1name.text = "YOU";
            Char1speech.text = "*Sight* That was close... I thought she was going to throw her flip-flop again!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            Char1name.text = "YOU";
            Char1speech.text = "She is  right... I need to sleep. I have work to do tomorrow. But...";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            Char1name.text = "YOU";
            Char1speech.text = "I'm not even sleepy...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 5)
        {
            Char1name.text = "YOU";
            Char1speech.text = "The sleeping pills can help again. I just hope... I won't oversleep again.";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 6)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Or I can try to to use my imagination!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 7)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "VOICE";
            Char2speech.text = "Or... You cAn ChIT CHaT with ME a LitTLE bit. I PROMISE it WiLL HELP MoRe ThaN SLEEPING PILLS.";
        }
        else if (primeInt == 8)
        {
            Char1name.text = "YOU";
            Char1speech.text = "Ugh, I'm hearing that voice again... I really want to know who is talking to me. Is... Is it really just in my mind?";
            Char2name.text = "";
            Char2speech.text = "";
            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice8a.SetActive(true); // function Choice1aFunct()
            Choice8b.SetActive(true); // function Choice1bFunct()
            Choice8c.SetActive(true); // function Choice1bFunct()
        }
        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
            Char1name.text = "YOU";
            Char1speech.text = "*Gulp*";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 101)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "VOICE";
            Char2speech.text = "NOOO!!!";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }


        else if (primeInt == 200)
        {
            Char1name.text = "YOU";
            Char1speech.text = "I just need to close my eyes and... ";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 201)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "???";
            Char2speech.text = "Are you really sure about that?";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }
        else if (primeInt == 300)
        {
            ArtChar1.SetActive(true);
            StartCoroutine(FadeIn(ArtChar1));
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "???";
            Char2speech.text = "Don't worry... I'm just your little demon!";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene3Button.SetActive(true);
        }
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice8aFunct()
    {
        Char1name.text = "YOU";
        Char1speech.text = "Let's take the pills and hope for the best!";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 99;
        Choice8a.SetActive(false);
        Choice8b.SetActive(false);
        Choice8c.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice8bFunct()
    {
        Char1name.text = "YOU";
        Char1speech.text = "I can do whatever I want in my dream!";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 199;
        Choice8a.SetActive(false);
        Choice8b.SetActive(false);
        Choice8c.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice8cFunct()
    {
        Char1name.text = "YOU";
        Char1speech.text = "That voice... Who are you? W...What do you want to talk?";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 299;
        Choice8a.SetActive(false);
        Choice8b.SetActive(false);
        Choice8c.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }


    public void SceneChange8a()
    {
        SceneManager.LoadScene("End_Win");
    }
    public void SceneChange8b()
    {
        SceneManager.LoadScene("End_Lose");
    }
    public void SceneChange8c()
    {
        SceneManager.LoadScene("Scene8c");
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
}