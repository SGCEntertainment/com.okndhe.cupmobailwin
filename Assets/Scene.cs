using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void Game()
    {
        SceneManager.LoadScene(1);
    }

    public void App()
    {
        SceneManager.LoadScene(0);
    }

}
