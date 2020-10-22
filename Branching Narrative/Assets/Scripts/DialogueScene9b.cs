using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene9b : MonoBehaviour
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
        ArtChar1.SetActive(true);
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
            Char1speech.text = "(Why I can't move?)";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            Char1name.text = "YOU";
            Char1speech.text = "(Why my body doesn't respond?)";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            Char2speech.gameObject.GetComponentInParent<shaker>().ChangeShake(1f);
            ArtChar1.SetActive(false);
            StartCoroutine(FadeIn(ArtChar2));
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "DEMON";
            Char2speech.text = "You know, I'm still waiting. Right?";
        }
        else if (primeInt == 5)
        {
            Char2speech.gameObject.GetComponentInParent<shaker>().ChangeShake(2f);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "DEMON";
            Char2speech.text = "Come on...";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt ==6)
        {
            Char2speech.gameObject.GetComponentInParent<shaker>().ChangeShake(8f);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "DEMON";
            Char2speech.text = "Let's be friend.";
        }
        else if (primeInt == 7)
        {
            Char2speech.gameObject.GetComponentInParent<shaker>().ChangeShake(2f);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "DEMON";
            Char2speech.text = "Are you still scared?";
        }
        else if (primeInt == 8)
        {
            Char2speech.gameObject.GetComponentInParent<shaker>().ChangeShake(1f);
            Char1name.text = "YOU";
            Char1speech.text = "(*Sob* This is not real.)";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 9)
        {
            Char2speech.gameObject.GetComponentInParent<shaker>().ChangeShake(1f);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "DEMON";
            Char2speech.text = "Awww... Are you a cry baby?";
        }
        else if (primeInt == 10)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "DEMON";
            Char2speech.text = "Shame... You can't move...";
            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice10a.SetActive(true); // function Choice1aFunct()
            Choice10b.SetActive(true); // function Choice1bFunct()
        }
        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
            StartCoroutine(FadeOut(ArtChar2));
            ArtBG2.SetActive(true);
            ArtBG1.SetActive(false);
            Char1name.text = "YOU";
            Char1speech.text = "NO!";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt ==101)
        {
            Char1name.text = "YOU";
            Char1speech.text = "I...it was sleep paralysis... \nI'm awake, it was just the dream...";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }

        else if (primeInt == 200)
        {
            Char2speech.gameObject.GetComponentInParent<shaker>().ChangeShake(10f);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "DEMON";
            Char2speech.text = "HaHaHaHa...";
        }
        else if (primeInt == 201)
        {
            Char2speech.gameObject.GetComponentInParent<shaker>().ChangeShake(2f);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "DEMON";
            Char2speech.text = "You really did entertain me! You should have go to bed early!";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice10aFunct()
    {
        Char1name.text = "YOU";
        Char1speech.text = "(I have to wake up! I have to push it away!)";
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
        Char1speech.text = "(This is not real... not real... real...)";
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
