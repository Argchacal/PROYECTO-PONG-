using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    //SerializeField, lo agregamos a la variable para poder modificarlo en el inspector
    [SerializeField] private float speed = 7f;
    [SerializeField] private bool isPaddle1;
    private float yBound = 3.75f;//establece el limite de movimientos de las paletas
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //detectamos el movimiento de teclado.
        float movement;
        if (isPaddle1)
        {
            movement = Input.GetAxisRaw("Vertical");
        }
        else{
            movement = Input.GetAxisRaw("Vertical2");
        }
        Vector2 paddleposition =  transform.position;//se le asigna la posicion de la paletas
        //Con Mathf.Clamp evito que se valla de los limites en este caso yBound
        paddleposition.y = Mathf.Clamp(paddleposition.y + movement * speed * Time.deltaTime, -yBound, yBound);
        transform.position= paddleposition;        
    }
}
