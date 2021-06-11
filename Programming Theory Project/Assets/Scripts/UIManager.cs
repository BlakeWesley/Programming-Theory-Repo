using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    // Super basic Scene manager to go from title screen to game.
    public void GoToScene()
    {
        SceneManager.LoadScene(1);
    }
}
