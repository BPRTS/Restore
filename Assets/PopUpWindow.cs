using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PopUpWindow : MonoBehaviour
{
    public TMP_Text popupText;

    private GameObject window;
    private Animator popupAnimator;

    private Queue<string> popupQueue;

    private Coroutine queueChecker;

    private void Awake()
    {
        window = transform.GetChild(0).gameObject;
        popupAnimator = window.GetComponent<Animator>();
        window.SetActive(false);
        popupQueue = new Queue<string>();
    }
    public void AddToQueue(string text)
    {
/*        if (popupQueue == null)
        {
            popupQueue = new Queue<string>();
        }*/
        popupQueue.Enqueue(text);
        if(queueChecker == null)
        {
            queueChecker = StartCoroutine(CheckQueue());
        }    
    }

    private void ShowPopup(string text)
    {
        window.SetActive(true);
        popupText.text = text;
        popupAnimator.Play("PopUpAnimation");
    }

    private IEnumerator CheckQueue()
    {
        do
        {
            ShowPopup(popupQueue.Dequeue());
            do
            {
                yield return null;

            } while (!popupAnimator.GetCurrentAnimatorStateInfo(0).IsTag("Idle"));

        } while (popupQueue.Count > 0);
        window.SetActive(false);
        queueChecker= null; 
    }
}
