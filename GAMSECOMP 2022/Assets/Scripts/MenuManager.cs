using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void proximaCena(string cena){
        SceneManager.LoadScene(cena);
    }
}
