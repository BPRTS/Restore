using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        SceneManager.UnloadScene(1);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void OpenWCD()
    {
        Application.OpenURL("https://www.worldcleanupday.nl");
    }

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

}
