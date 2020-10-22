using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene8c : MonoBehaviour
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
    public GameObject Choice9a;
    public GameObject Choice9b;
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
        Choice9a.SetActive(false);
        Choice9b.SetActive(false);
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
            Char1speech.text = "(W...Wha...What the hell?!)";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "DEMON";
            Char2speech.text = "Hm... Are you still confused?";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            StartCoroutine(FadeIn(ArtChar2));
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "DEMON";
            Char2speech.text = "Don't worry.";
        }
        else if (primeInt == 5)
        {
            Char2speech.gameObject.GetComponentInParent<shaker>().ChangeShake(2f);
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            StartCoroutine(FadeIn(ArtChar2));
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "DEMON";
            Char2speech.text = "I don't bite.";
        }
        else if (primeInt == 6)
        {
            Char2speech.gameObject.GetComponentInParent<shaker>().ChangeShake(0f);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "DEMON";
            Char2speech.text = "I just want to be friend.";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 7)
        {
            Char1name.text = "YOU";
            Char1speech.text = "(W...What? A friend... with demon?)";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 8)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "DEMON";
            Char2speech.text = "...Oh, yes. Just a friend.";
        }
        else if (primeInt == 9)
        {
            Char2speech.gameObject.GetComponentInParent<shaker>().ChangeShake(3f);
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            StartCoroutine(FadeIn(ArtChar2));
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "DEMON";
            Char2speech.text = "like your little friend JIMMY!";
        }
        else if (primeInt == 10)
        {
            Char2speech.gameObject.GetComponentInParent<shaker>().ChangeShake(1f);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "DEMON";
            Char2speech.text = "Wouldn't be so cool, hmm?";
            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice9a.SetActive(true); // function Choice1aFunct()
            Choice9b.SetActive(true); // function Choice1bFunct()
        }
        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
            Char1name.text = "YOU";
            Char1speech.text = "(I have to call my mom!)";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }

        else if (primeInt == 200)
        {
            Char1name.text = "YOU";
            Char1speech.text = "(I have to leave the bed... I have to run!)";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice9aFunct()
    {
        Char1name.text = "YOU";
        Char1speech.text = "(N...No! This is just a dream!)";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 99;
        Choice9a.SetActive(false);
        Choice9b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice9bFunct()
    {
        Char1name.text = "YOU";
        Char1speech.text = "(N...No! This can't be real! A Demon?!)";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 199;
        Choice9a.SetActive(false);
        Choice9b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    public void SceneChange9a()
    {
        SceneManager.LoadScene("Scene9a");
    }
    public void SceneChange9b()
    {
        SceneManager.LoadScene("Scene9b");
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
