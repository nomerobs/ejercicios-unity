using UnityEngine;

public class piedra_papel_tijeras : MonoBehaviour
{
    int playerAWin = 0;
    int playerBWin = 0;

    int playerA;
    int playerB;

    void Start()
    {
        while (playerAWin < 5 && playerBWin < 5)
        {
            playerA = Random.Range(1, 4);
            playerB = Random.Range(1, 4);

            // Empate
            if (playerA == playerB)
            {
                Debug.Log("Empate");
            }
            // Player A gana
            else if (
                (playerA == 1 && playerB == 3) ||
                (playerA == 2 && playerB == 1) ||
                (playerA == 3 && playerB == 2)
            )
            {
                playerAWin++;
                Debug.Log("A win");
            }
            // Player B gana
            else
            {
                playerBWin++;
                Debug.Log("B win");
            }
        }

        if (playerAWin >= 5)
            Debug.Log("A win final");
        else
            Debug.Log("B win final");
    }
}
