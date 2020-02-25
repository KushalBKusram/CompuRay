using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class SpeechManager : MonoBehaviour
{
    KeywordRecognizer keywordRecognizer = null;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();
    GameObject Menu;
    GameObject Cursor;
    GameObject AppText;
    GameObject CloseMenu;
    GameObject ShowMenu;
    GameObject Tutorial;

    // Use this for initialization
    void Start()
    {
        Menu = GameObject.Find("Menu");
        Cursor = GameObject.Find("GazeCursor");
        AppText = GameObject.Find("AppText");
        CloseMenu = GameObject.Find("CloseMenu");
        ShowMenu = GameObject.Find("ShowMenu");
        Tutorial = GameObject.Find("Tutorial");
        
        Menu.SetActive(false);
        CloseMenu.SetActive(false);
        Tutorial.SetActive(false);

        keywords.Add("Show Menu", () =>
        {
            // Call the OnReset method on every descendant object.
            Menu.SetActive(true);
            Cursor.SetActive(false);
            AppText.SetActive(false);
            ShowMenu.SetActive(false);
            CloseMenu.SetActive(true);
        });
        keywords.Add("Close Menu", () =>
        {
            // Call the OnReset method on every descendant object.
            Menu.SetActive(false);
            Cursor.SetActive(true);
            AppText.SetActive(true);
            ShowMenu.SetActive(true);
            CloseMenu.SetActive(false);
        });
        keywords.Add("Reset World", () =>
        {
            
        });
        keywords.Add("Show Tutorial", () =>
        {
            Menu.SetActive(false);
            Cursor.SetActive(false);
            AppText.SetActive(false);
            ShowMenu.SetActive(false);
            CloseMenu.SetActive(false);
            Tutorial.SetActive(true);
        });
        keywords.Add("Close Tutorial", () =>
        {
            Cursor.SetActive(true);
            AppText.SetActive(true);
            ShowMenu.SetActive(true);
            Tutorial.SetActive(false);
        });

        // Tell the KeywordRecognizer about our keywords.
        keywordRecognizer = new KeywordRecognizer(keywords.Keys.ToArray());

        // Register a callback for the KeywordRecognizer and start recognizing!
        keywordRecognizer.OnPhraseRecognized += KeywordRecognizer_OnPhraseRecognized;
        keywordRecognizer.Start();
    }

    private void KeywordRecognizer_OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        System.Action keywordAction;
        if (keywords.TryGetValue(args.text, out keywordAction))
        {
            keywordAction.Invoke();
        }
    }
}