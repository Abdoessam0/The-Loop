using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [Header("Optional Settings Panel")]
    [SerializeField] private GameObject settingsPanel;

    // Called when Start button is clicked
    public void OnStartClick()
    {
        SceneManager.LoadScene("Stage1");
    }

    // Called when Exit button is clicked
    public void OnExitClick()
    {
#if UNITY_EDITOR
        // Stop play mode if testing inside the editor
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
        Debug.Log("Game exited");
    }

    // Called when Settings button is clicked (if you re-add it later)
    public void ToggleSettings(bool show)
    {
        if (settingsPanel != null)
            settingsPanel.SetActive(show);
    }
}
