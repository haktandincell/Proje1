using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DilSecme : MonoBehaviour
{
    public void PythonLoadLevel()
    {
        SceneManager.LoadScene("Python1");
    }

    public void CSharpLoadLevel()
    {
        SceneManager.LoadScene( "CSharp1");
    }

    public void CLoadLevel() 
    { 
        SceneManager.LoadScene("C1");
    }
}
