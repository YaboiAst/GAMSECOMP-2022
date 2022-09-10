using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    public PlayerCooking capivara;
    /*
        0 - feijão
        1 - calabresa
        2 - carne seca
        3 - bacon

        4 - calabresa cortada
        5 - bacon picado

        6 - bacon frito

        7 - prato de feijoada
    */


    // Interação com o armazém
    public void pegarIngrediente(int n){
        if(capivara.temIngrediente == 0){
            capivara.temIngrediente = n;
        }
        Debug.Log("Pegou ingrediente");
    }

    // Interação com o fogão
    public void fritar(){
        if(capivara.temIngrediente == 5){
            Debug.Log("Fritando bacon");
            waiter(2);
            capivara.temIngrediente = 6;
            Debug.Log("Bacon pronto!");
        }
        else Debug.Log("Isso nao vai aqui");
    }

    // Interação com a tabua
    public void cortar(){
        if(capivara.temIngrediente == 1){
            Debug.Log("Picando calabresa");
            waiter(2);
            Debug.Log("Calabresa picada");
        }
        else if(capivara.temIngrediente == 3){
            Debug.Log("Picando bacon");
            waiter(2);
            capivara.temIngrediente = 5;
            Debug.Log("Bacon picado");
        }
        else Debug.Log("Isso nao vai aqui");
    }

    // Interação com o prato
    public void empratar(){
        Debug.Log("x adicionado ao prato");
    }

    // Interação com o balcão (Score?)
    public void entregarPrato(){
        Debug.Log("Finally, some good fuckin food");
    }


    IEnumerator waiter(int time){
        yield return new WaitForSeconds(time);
    }
}
