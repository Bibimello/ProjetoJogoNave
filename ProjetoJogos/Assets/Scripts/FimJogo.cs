using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FimJogo : MonoBehaviour
{
   public Text textoPontuacao;
   
    public void Exibir () {
        this.gameObject.SetActive(true);
        this.textoPontuacao.text = (ControladorPontuacao.Pontuacao + "x");
    }
    public void Esconder(){
        this.gameObject.SetActive(false);
    }
    public void TentarNovamente(){
     SceneManager.LoadScene("Jogo");
    }
}
