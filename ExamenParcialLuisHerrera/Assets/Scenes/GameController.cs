using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{

    enum elements {VotoFavor = 1 , VotoContra =2 }

    private int playerChoose = -1;
    private int botChoose = -1;

    private bool playersTurn = true;


    void CheckWinner()
    {
        if(playerChoose == botChoose)
        {
            //text.tex ("EMPATE");
        }
        else if (playerChoose == (int)elements.VotoFavor && botChoose == (int)elements.VotoContra)
        {
            //text.text "GANASTE"
        }
         else if (playerChoose == (int)elements.VotoContra && botChoose == (int)elements.VotoFavor)
        {
            //text.text "PERDISTE"
        }
    }
}




