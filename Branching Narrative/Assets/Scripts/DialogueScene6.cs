using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene6 : MonoBehaviour
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
            dialogue.SetActive(true);
            Char1name.text = playerName;
            StartCoroutine(TypeText(Char1speech, "You were right Jimmy, a few more games wouldn't hurt! " ));
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
            StartCoroutine(TypeText(Char2speech, "Right? More fun doesn't hurt anybody! " ));
            Char3name.text = "";
            Char3speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            Char1name.text = playerName;
            StartCoroutine(TypeText(Char1speech, "Ok, lets keep going then! " ));
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
            StartCoroutine(TypeText(Char2speech, "Sure thing! " ));
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 6)
        {
            ArtChar3.SetActive(false);
            ArtChar1.SetActive(true);
            StartCoroutine(FadeIn(ArtChar1));
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
            Char1name.text = playerName;
            StartCoroutine(TypeText(Char1speech, "Oh no, that's my mom, she found out. " ));
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 7)
        {
            StartCoroutine(FadeOut(ArtChar1));
            ArtChar4.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "JIMMY";
            StartCoroutine(TypeText(Char2speech, "I told you if you get caught it isnt my fault, you're on your own buddy. " ));
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 8)
        {
            ArtChar4.SetActive(false);
            Char1name.text = playerName;
            Char1speech.text = "Huh? How am I going to run from this??";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
            else if (primeInt == 9)
            {
                ArtChar2.SetActive(true);
            StartCoroutine(FadeIn(ArtChar2));
            Char3speech.gameObject.GetComponentInParent<shaker>().ChangeShake(2f);
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
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "MOM";
            Char3speech.text = "*GRABS FLIP FLOPS*";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }

        else if (primeInt == 200)
        {
            StartCoroutine(FadeOut(ArtChar2));
            Char1name.text = playerName;
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
    public void Choice1aFunct()
    {
        
        Char1name.text = playerName;
        Char1speech.text = "No! I don't want to!!";
        Char2name.text = "";
        Char2speech.text = "";
        Char3name.text = "";
        Char3speech.text = "";
        primeInt = 99;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
        
    }
    public void Choice1bFunct()
    {
        Char1name.text = playerName;
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