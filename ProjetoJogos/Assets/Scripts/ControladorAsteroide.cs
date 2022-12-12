using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorAsteroide : MonoBehaviour
{
    public Asteroide asteroideOriginal;
    private float tempoDecorrido;


    // Start is called before the first frame update
    void Start()
    {
        this.tempoDecorrido = 0;
    }

    // Update is called once per frame
    void Update()
    {
        this.tempoDecorrido += Time.deltaTime;
        if (this.tempoDecorrido >= 1f) {
            this.tempoDecorrido = 0;

           Vector2 posicaoMaxima = Camera.main.ViewportToWorldPoint(new Vector2(1,1));
           Vector2 posicaoMinima = Camera.main.ViewportToWorldPoint(new Vector2(0,0));


           float posicaoX = Random.Range(posicaoMinima.x ,posicaoMaxima.x);
           Vector2 posicaoAsteroide = new Vector2 (posicaoX ,posicaoMaxima.y);

            Instantiate (this.asteroideOriginal,posicaoAsteroide,Quaternion.identity);
        }
    }
}
