using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Text score;

    // Start is called before the first frame update
    void Start()
    {
        score.text = "Score: " + GameManager.Score;

        HUD.HUDManager.UpdateScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackButton()
    {
        SceneManager.LoadScene(0);
    }
}
