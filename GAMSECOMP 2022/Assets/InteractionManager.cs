using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    // Interação com o armazém
    public void pegarIngrediente(){
        Debug.Log("Pegou ingrediente");
    }

    // Interação com o fogão
    public void cozinhar(){
        Debug.Log("Cozinhando");
    }

    // Interação com a tabua
    public void cortar(){
        Debug.Log("Preparando ingrediente");
    }

    // Interação com o prato
    public void empratar(){
        Debug.Log("x adicionado ao prato");
    }

    // Interação com o balcão (Score?)
    public void entregarPrato(){
        Debug.Log("Finally, some good fuckin food");
    }
}
