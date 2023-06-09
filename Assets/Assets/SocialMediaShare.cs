using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;


public class SocialMediaShare : MonoBehaviour
{
    [SerializeField] GameObject panelShare;

    public void ShareInfo()
    {
        panelShare.SetActive(true);
        StartCoroutine("TakeScreenshotAndShare");
    }
    IEnumerator TakeScreenshotAndShare()
    {
        yield return new WaitForEndOfFrame();
        Texture2D tx = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        tx.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        tx.Apply();

        string path = Path.Combine(Application.temporaryCachePath, "sharedImage.png");
        File.WriteAllBytes(path, tx.EncodeToPNG());
        Destroy(tx);

        new NativeShare().AddFile(path).SetSubject("World Cleanup Day is coming!").SetText("Start planning now to help a cleanup event near you!").Share();
        panelShare.SetActive(false);
    }

    public void OpenWCD()
    {
        Application.OpenURL("https://www.worldcleanupday.nl/donate/choose");
    }
    public void OpenMap()
    {
        Application.OpenURL("https://www.worldcleanupday.nl/participate");
    }
    public void CopyToClipboard()
    {
        GUIUtility.systemCopyBuffer = "https://www.worldcleanupday.nl/projects/participate";
    }


}

