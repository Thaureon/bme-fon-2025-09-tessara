using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete2D : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            Time.timeScale = 0;
            SceneManager.LoadScene("VictoryMenu", LoadSceneMode.Additive);
            SceneManager.UnloadSceneAsync("PauseMenu");
        }
    }
}
