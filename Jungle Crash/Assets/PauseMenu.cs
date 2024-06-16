using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false; // Variable statique pour suivre l'état de pause

    public GameObject pauseMenuUI; // Référence à l'UI du menu de pause

    public GameObject settingsWindow; 

    void Update()
    {
        // Vérifie si la touche Escape est enfoncée
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Bascule entre pause et reprise
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Paused(); 
            }
        }
    }

    // Méthode pour mettre le jeu en pause
    void Paused() 
    {
        pauseMenuUI.SetActive(true); // Affiche le menu de pause
        Time.timeScale = 0; // Met le jeu en pause
        gameIsPaused = true; // Indique que le jeu est en pause
    }

    // Méthode pour reprendre le jeu
    public void Resume()
    {
        pauseMenuUI.SetActive(false); // Cache le menu de pause
        Time.timeScale = 1; // Reprend le jeu
        gameIsPaused = false; // Indique que le jeu n'est plus en pause
    }

    public void OpenSettingsWindow()
    {
        settingsWindow.SetActive(true);
    }

     public void CloseSettingsWindow()
    {
        settingsWindow.SetActive(false);
    }
    
    // Méthode pour charger le menu principal
    public void LoadMainMenu()
    {
        Resume(); // Reprend le jeu avant de charger la nouvelle scène
        SceneManager.LoadScene("MainMenu"); // Charge la scène du menu principal
    }
}
