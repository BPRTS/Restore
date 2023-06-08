using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncyclopediaUITabs : MonoBehaviour
{
    public GameObject waterBottle;
    public GameObject plasticBag;
    public GameObject plasticFlatware;
    public GameObject plasticRings;
    public GameObject takeoutContainer;
    public GameObject woodenPlank;
    public GameObject metalCan;
    public GameObject acrylicPanel;
    public GameObject nylonTwine;
    public GameObject woodenPanel;
    public GameObject refinedMetal;

    public GameObject infoPanel;

    public void Start()
    {
        HideAllWindows();
    }
    public void HideAllWindows()
    {
        waterBottle.SetActive(false);
        plasticBag.SetActive(false);
        plasticFlatware.SetActive(false);
        plasticRings.SetActive(false);
        takeoutContainer.SetActive(false);
        woodenPlank.SetActive(false);
        metalCan.SetActive(false);
        acrylicPanel.SetActive(false);
        nylonTwine.SetActive(false);
        woodenPanel.SetActive(false);
        refinedMetal.SetActive(false);

        infoPanel.SetActive(false);
    }


    public void ShowWaterBottle()
    {
        HideAllWindows();
        infoPanel.SetActive(true);
        waterBottle.SetActive(true);
    }
    public void ShowPlasticBag()
    {
        HideAllWindows();
        infoPanel.SetActive(true);
        plasticBag.SetActive(true);
    }
    public void ShowPlasticFlatware()
    {
        HideAllWindows();
        infoPanel.SetActive(true);
        plasticFlatware.SetActive(true);
    }
    public void ShowPlasticRings()
    {
        HideAllWindows();
        infoPanel.SetActive(true);
        plasticRings.SetActive(true);
    }
    public void ShowTakeoutContainer()
    {
        HideAllWindows();
        infoPanel.SetActive(true);
        takeoutContainer.SetActive(true);
    }
    public void ShowWoodenPlank()
    {
        HideAllWindows();
        infoPanel.SetActive(true);
        woodenPlank.SetActive(true);
    }
    public void ShowMetalCan()
    {
        HideAllWindows();
        infoPanel.SetActive(true);
        metalCan.SetActive(true);
    }
    public void ShowAcrylicPanel()
    {
        HideAllWindows();
        infoPanel.SetActive(true);
        acrylicPanel.SetActive(true);
    }
    public void ShowNylonTwine()
    {
        HideAllWindows();
        infoPanel.SetActive(true);
        nylonTwine.SetActive(true);
    }
    public void ShowWoodenPanel()
    {
        HideAllWindows();
        infoPanel.SetActive(true);
        woodenPanel.SetActive(true);
    }
    public void ShowRefinedMetal()
    {
        HideAllWindows();
        infoPanel.SetActive(true);
        refinedMetal.SetActive(true);
    }

}
