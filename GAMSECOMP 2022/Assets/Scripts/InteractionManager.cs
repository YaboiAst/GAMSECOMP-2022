using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    public PlayerCooking capivara;
    public List<Ingrediente> receita;

    // Interação com o armazém
    public void pegarIngrediente(Ingrediente ingrediente){
        if(!capivara.isHolding){
            capivara.holding = ingrediente;
            capivara.isHolding = true;
        }
    }

    // Interação com a tabua
    public void cortar(){
        if(capivara.isHolding && capivara.holding.canCut){
            capivara.holding.isCut = true;
            capivara.holding.canCook = true;
        }
    }

    // Interação com o fogão
    public void cozinhar(){
        if(capivara.holding != null && capivara.holding.canCook){
            if((capivara.holding.canCut && capivara.holding.isCut) || (!capivara.holding.canCut && !capivara.holding.isCut)){
                receita.Remove(capivara.holding);
                capivara.isHolding = false;
                capivara.holding = null;
            }
        }
        else if(capivara.isPlate && receita.Count == 0){
            capivara.hasFeijoada = true;
        }
    }


    // Interação com o prato
    public void empratar(){
        if(!capivara.isHolding){
            capivara.isHolding = true;
            capivara.isPlate = true;
        }
    }

    // Interação com o balcão (Score?)
    public void entregarPrato(){
        if(capivara.isHolding && capivara.hasFeijoada){
            Debug.Log("Pedido completo! Feijoada nada acontece");
        }
    }

    public void descartar(){
        if(capivara.isHolding){
            capivara.isHolding = false;
            capivara.holding = null;
            capivara.isPlate = false;
        }
    }
}
