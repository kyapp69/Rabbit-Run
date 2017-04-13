using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainManager : MonoBehaviour {

    public void GameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
