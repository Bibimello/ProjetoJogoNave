using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
       public Rigidbody2D rigidbody;
       public float velocidadeY;


    // Start is called before the first frame update
    void Start()
    {
        this.rigidbody.velocity = new Vector2(0,this.velocidadeY);

    }
    public void OnTriggerEnter2D(Collider2D collider) {
    if (collider.CompareTag("Asteroide")) {
        //Destroi o asteroide
       Asteroide asteroide = collider.GetComponent<Asteroide>();
       asteroide.Destruir(true);
        // Destroi o proprio laser
        Destroy (this.gameObject);
    }
    }
}
