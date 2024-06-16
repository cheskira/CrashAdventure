using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public void LoadLevelPassed(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu"); // Charge la scène du menu principal
    }

}
