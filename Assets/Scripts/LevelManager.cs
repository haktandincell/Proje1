using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public int nextlevel;
    public void LoadLevel()
    {
        SceneManager.LoadScene(nextlevel);
    }
}
