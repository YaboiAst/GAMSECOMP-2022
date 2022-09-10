using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interacoes : MonoBehaviour{
    public bool isInRange;
    public UnityEvent interacao;

    private void Update() {
        if(isInRange && Input.GetKeyDown(KeyCode.Space) && interacao != null){
            interacao.Invoke();
        }
    }
    private void OnCollisionEnter2D(Collision2D other) {
        isInRange = true;
    }

    private void OnCollisionExit2D(Collision2D other) {
        isInRange = false;
    }
}
