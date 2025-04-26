using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;  // Import TextMeshPro namespace

public class GameOverScreen : MonoBehaviour
{
    public GameObject gameOverPanel;           // Assign the Game Over UI panel
    public TextMeshProUGUI restartButtonText;  // Assign in Inspector
    public TextMeshProUGUI exitButtonText;     // Assign in Inspector

    void Start()
    {
        if (gameOverPanel != null)
            gameOverPanel.SetActive(false);  // Hide the panel at start

        // Optional: Set button text if you want
        if (restartButtonText != null)
            restartButtonText.text = "Restart";

        if (exitButtonText != null)
            exitButtonText.text = "Exit";
    }

    public void ShowGameOver()
    {
        if (gameOverPanel != null)
            gameOverPanel.SetActive(true);   // Show Game Over panel
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Game"); // Reload current scene
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("MainMenu");  // Load main menu scene
    }
}