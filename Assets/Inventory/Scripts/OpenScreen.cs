using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenScreen : MonoBehaviour
{
    public GameObject craftWindow;
    public void OpenCraft()
    {
        craftWindow.SetActive(true);
    }
    public void CloseCraft()
    {
        craftWindow.SetActive(false);
    }
}
