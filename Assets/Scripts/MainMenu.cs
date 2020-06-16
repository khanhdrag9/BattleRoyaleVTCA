using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button playBtn;

    void Start()
    {
        playBtn.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Gameplay");
        });

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
