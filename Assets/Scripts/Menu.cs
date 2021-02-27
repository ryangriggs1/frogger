using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Dropdown dropdown;
    public static int lives;
    public Text livesText;
    public Text inputName;
    public static string playerName;

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        StoreName();
    }

    public void QuitGame()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }

    public void GoCredits()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void GoMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void GameRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void HandleInputData()
    {
        switch (dropdown.value)
        {
            case 0:
                livesText.text = "You will have 1 life";
                lives = 1;
                break;
            case 1:
                livesText.text = "You will have 2 lives";
                lives = 2;
                break;
            case 2:
                livesText.text = "You will have 3 lives";
                lives = 3;
                break;
        }
    }

    public void StoreName()
    {
        playerName = inputName.text;

    }

}
