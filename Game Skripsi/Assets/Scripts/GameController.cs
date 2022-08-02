using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Play Scene");
    }

    public void InstructionGame()
    {
        SceneManager.LoadScene("Instruction Scene");
    }

    public void CreditGame()
    {
        SceneManager.LoadScene("Credit Scene");
    }

    public void MenuGame()
    {
        SceneManager.LoadScene("Menu Scene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
