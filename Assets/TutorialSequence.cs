using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TutorialSequence : MonoBehaviour
{
    public Canvas maincanvas;


    private List<string> text = new List<string>()
    { 
        "How to move",
        "text2",
        "text3",
        "text4"
    };
    public TMP_Text textbox;
    public int stage = 0;
    private Coroutine coroutineChecker;
    private List<bool> stageflags = new List<bool>()
    {
        false, false, false, false
    };

    // Start is called before the first frame update
    void Start()
    {
       // maincanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
     if(stage == 0 && !stageflags[0])
        {
            stageflags[0] = true;
            textbox.text = text[0];
            maincanvas.transform.GetChild(0).gameObject.SetActive(true);
        }
     else if (stage == 1 && !stageflags[1])
            {
            stageflags[1] = true;
            textbox.text = text[1];
        }
     else if (stage == 2 && !stageflags[2])
        {
            stageflags[2] = true;
            textbox.text = text[2];
            maincanvas.transform.GetChild(1).gameObject.SetActive(true);
        }
        else
        {
            Debug.Log(stage);
        }
    }
}


