using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTrigger : MonoBehaviour
{
    private GameController gameController;

    private void Start() {
        gameController = FindObjectOfType<GameController>();
    }

    private void OnTriggerEnter2D(Collider2D target) //Quando a bola bate no colisor
    {  
        if(target.gameObject.CompareTag("Destroyer")) // Quando cair fora do chapéu
        {
            Destroy(this.gameObject);
        }
        else if(target.gameObject.CompareTag("Point")) // Quando cai dentro do chapéu
        {
            gameController.score++;
            Destroy(this.gameObject);
        }
    }
}
