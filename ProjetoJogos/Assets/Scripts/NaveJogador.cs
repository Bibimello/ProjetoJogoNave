using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveJogador : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public float velocidadeMovimento;

    public Laser laserPrefab;
    public float tempoEsperaTiro;
    private float intervaloTiro;

    private int vidas;

   private FimJogo TelaFimJogo;
    

    // Start is called before the first frame update
    void Start()
    {
        this.vidas = 5;
        ControladorPontuacao.Pontuacao = 0;

        GameObject fimJogoGameObject = GameObject.FindGameObjectWithTag("TelaFimJogo");
        this.TelaFimJogo = fimJogoGameObject.GetComponent<FimJogo>();
        this.TelaFimJogo.Esconder();
    }

    // Update is called once per frame
    void Update()
    {
       this.intervaloTiro += Time.deltaTime;
       if(this.intervaloTiro >= this.tempoEsperaTiro) {
           this.intervaloTiro = 0;
           Atirar();
       }

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        float velocidadeX = (horizontal * this.velocidadeMovimento);
        float velocidadeY = (vertical * this.velocidadeMovimento);
        
        this.rigidbody.velocity = new Vector2 (velocidadeX,velocidadeY);

    }
     private void OnTriggerEnter2D (Collider2D collider) {
         if (collider.CompareTag("Asteroide")) {
             Vida --;
             Asteroide asteroide = collider.GetComponent<Asteroide>();
             asteroide.Destruir(false);
         }
     }

    public int Vida {
        get {
            return this.vidas;
        }
        set {
            this.vidas = value;
            if (this.vidas < 0) {
                this.vidas = 0;
                //Exibir tela de fim de jogo
                TelaFimJogo.Exibir();

            }
        }
    }
    private void Atirar () {
        Instantiate (this.laserPrefab,this.transform.position,Quaternion.identity);
        
    }
}
