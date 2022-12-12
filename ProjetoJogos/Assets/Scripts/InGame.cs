using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGame : MonoBehaviour
{
    public Text textoPontuacao;
    public BarraVida barraVida;
   
    private NaveJogador player;

    private void Start () {
        this.player = GameObject.FindGameObjectWithTag("Player").GetComponent<NaveJogador>();
    }
    // Update is called once per frame
    void Update()
    {
        this.barraVida.ExibirVida(this.player.Vida);
        this.textoPontuacao.text = (ControladorPontuacao.Pontuacao + "x");
    }
}
