using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets._Scripts.MenuScripts
{
    public class NavigationManager : MonoBehaviour
    {
        public void MoveScenes(string newScene)
        {
            SceneManager.LoadScene(newScene);
        }

        public void ExitApplication()
        {
            Application.Quit();
        }
    }
}
