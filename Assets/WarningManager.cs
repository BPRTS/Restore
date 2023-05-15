using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WarningManager : MonoBehaviour
{

    public GameObject warning;
    private string text;

    // Start is called before the first frame update
   public IEnumerator Warning(string text)
    {
        warning.SetActive(true);
        warning.GetComponent<TextMeshProUGUI>().text = text;
        //warning.GetComponent<RawImage>().enabled = true;
        //warning.transform.GetChild(0).GetComponent<TextMeshProUGUI>().enabled = true;

        //TODO: Enable the warning

        yield return new WaitForSeconds(5);

        warning.SetActive(false);

    }
}
