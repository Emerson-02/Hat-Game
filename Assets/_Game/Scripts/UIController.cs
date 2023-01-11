using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{

    private GameController gameController;

    public GameObject panelMainMenu;

    // Start is called before the first frame update
    void Start()
    {
        gameController = FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonExit()
    {
        // Forma Genérica
        //if(Input.GetKeyDown(KeyCode.Escape)){
            //Application.Quit();
        //} // |Funciona tanto para android como para pc

        // Forma Android
        AndroidJavaObject activity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
        activity.Call<bool>("moveTaskToBack", true);
    }

    public void ButtonStartGame()
    {
        gameController.gameStarted = true; // inicia o jogo
        panelMainMenu.gameObject.SetActive(false); // desativa o painel
    }
}
