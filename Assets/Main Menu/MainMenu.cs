using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject optionsMenu;
    public GameObject volunteerMenu;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        SceneManager.UnloadSceneAsync(1);
    }
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
        SceneManager.UnloadSceneAsync(0);
    }

    public void OpenWCD()
    {
        Application.OpenURL("https://www.worldcleanupday.nl");
    }
    public void HideAllWindows()
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(false);
        volunteerMenu.SetActive(false);
    }
    public void OpenOptions()
    {
        HideAllWindows();
        optionsMenu.SetActive(true);
    }
    public void OpenMainMenu()
    {
        HideAllWindows();
        mainMenu.SetActive(true);
    }

    public void OpenVolunteer()
    {
        HideAllWindows();
        volunteerMenu.SetActive(true);
    }

    public void CopyToClipboard()
    {
        GUIUtility.systemCopyBuffer = "https://www.worldcleanupday.nl/projects/participate";
    }
    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

}
