using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    public GameObject VictoryPanel;

    private string _sceneName;

    public void Start()
    {
        _sceneName = SceneManager.GetActiveScene().name;
    }

    public void Update()
    {
    }
    public void ContinueGame()
    {
        Time.timeScale = 1;
        VictoryPanel.SetActive(false);
        //enable the scripts again
        Debug.Log("Resuming from Victory");
    }

    public void OnRestartButton()
    {
        SceneManager.LoadScene(_sceneName);
    }
}
