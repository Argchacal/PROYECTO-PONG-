using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text paddle1ScoreText;
    [SerializeField] private TMP_Text paddle2ScoreText;
    [SerializeField] private Transform paddle1Transform;
    [SerializeField] private Transform paddle2Transform;
    [SerializeField] private Transform ballTransform;
    private int paddle1Score;
    private int paddle2Score;
    //programacion sinclerton
    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
            }
            return instance;
        }
    }
    //metodos publicos para accederlos desde los otro scrips
    public void Paddle1Score()
    {
        paddle1Score++;
        paddle1ScoreText.text = paddle1Score.ToString();// aca mostramos en pantalla
       // if (paddle1Score >= 5)        {
            //MostrarGanador("Jugador 1 gano");        }
    }
    public void Paddle2Score()
    {
        paddle2Score++;
        paddle2ScoreText.text = paddle2Score.ToString();
        //if (paddle2Score >= 5)
       // {MostrarGanador("Jugador 2 gano");}
    }
    public void Restart()
    {
        paddle1Transform.position = new Vector2(paddle1Transform.position.x, 0);//
        paddle2Transform.position = new Vector2(paddle2Transform.position.x, 0);//
        ballTransform.position = new Vector2(0, 0);//
    }

   // public void MostrarGanador( string gano);
    //{        MostrarGanador.text = gano;      }

}
