using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WarningManager : MonoBehaviour
{

    public RawImage warning;
    private string text;

    // Start is called before the first frame update
   IEnumerator OxygenDrain()
    {
        text = "Warning! You are leaving the Safe Zone.";
        warning.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = text;
        //warning.GetComponent<RawImage>().enabled = true;
        //warning.transform.GetChild(0).GetComponent<TextMeshProUGUI>().enabled = true;

        //TODO: Enable the warning

        yield return new WaitForSeconds(5);

        //TODO: Disable the warning

    }
}
