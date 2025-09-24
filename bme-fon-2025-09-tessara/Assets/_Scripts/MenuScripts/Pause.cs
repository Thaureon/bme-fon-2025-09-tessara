using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject PausePanel;
    public TMP_Text LevelLabel;

    private string _sceneName;
    private InputAction _pauseAction;

    public void Start()
    {
        _pauseAction = InputSystem.actions.FindAction("Pause");

        _sceneName = SceneManager.GetActiveScene().name;
        LevelLabel.text = _sceneName;
    }

    public void Update()
    {
        if (_pauseAction.triggered)
        {
            if (!PausePanel.activeInHierarchy)
            {
                PauseGame();
            }
            else if (PausePanel.activeInHierarchy)
            {
                ContinueGame();
            }
        }
    }
    
    private void PauseGame()
    {
        Time.timeScale = 0;
        PausePanel.SetActive(true);
    }

    public void ContinueGame()
    {
        Time.timeScale = 1;
        PausePanel.SetActive(false);
    }
    
    public void OnRestartButton()
    {
        SceneManager.LoadScene(_sceneName);
    }
}
