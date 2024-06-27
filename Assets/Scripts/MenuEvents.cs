using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuEvents : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("levels123");
    }
}
