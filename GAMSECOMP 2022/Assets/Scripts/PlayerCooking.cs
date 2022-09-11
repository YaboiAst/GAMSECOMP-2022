using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCooking : MonoBehaviour
{       
    public bool isHolding;
    public bool isPlate;
    public bool hasFeijoada;
    public Ingrediente holding;
    public SpriteRenderer holdSlot;
    

    private void Update() {
        /*if(hasFeijoada){
            holding = GameObject.Find("Ingredientes/feijoada");
        }*/

        if(isHolding && !holding.isCut && holdSlot.sprite != holding.ingrediente){
            holdSlot.sprite = holding.ingrediente;
        }
        else if(isHolding && holding.isCut && holdSlot.sprite != holding.ingredienteCortado){
            holdSlot.sprite = holding.ingredienteCortado;
        }
        else if(!isHolding) holdSlot.sprite = null;
    }
}
