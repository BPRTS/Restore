using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvCraftTabs : MonoBehaviour
{
    public GameObject craftAcrylic;
    public GameObject craftNylon;
    public GameObject craftWood;
    public GameObject craftMetal;
    public GameObject parentClose;
    public GameObject instanceClose;

    public void Start()
    {
        HideAllWindows();
    }
    public void HideAllWindows()
    {
        craftAcrylic.SetActive(false);
        craftNylon.SetActive(false);
        craftWood.SetActive(false);
        craftMetal.SetActive(false);


    }


    public void ShowAcrylic()
    {
        HideAllWindows();
        craftAcrylic.SetActive(true);
    }

    public void ShowNylon()
    {
        HideAllWindows();
        craftNylon.SetActive(true);
    }

    public void ShowWood()
    {
        HideAllWindows();
        craftWood.SetActive(true);
    }

    public void ShowMetal()
    {
        HideAllWindows();
        craftMetal.SetActive(true);
    }
}
