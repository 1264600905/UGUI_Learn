using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMamger : MonoBehaviour {

    public void OnStartGame(string SceneName) {
        SceneManager.LoadScene(SceneName);
    }
    public void OnStartGame02(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
