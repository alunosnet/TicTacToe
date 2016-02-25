using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class boardGame : MonoBehaviour {

    public Texture[] players;
    public int[] matrix;
    public int playerPlaying = 0;
    public Text msg;

	// Use this for initialization
	void Start () {
        for (int i = 0; i < matrix.Length; i++)
            matrix[i] = -1;
	}
	
	public int getPlayerPlaying()
    {
        return playerPlaying;
    }

    public void playerPlayed(int position)
    {
        matrix[position] = playerPlaying;
        //check if someone won
        int temp = gameOver();
        if (temp != -1)
            msg.text = "Player " + temp.ToString() + " Won!";
        //next player
        playerPlaying++;
        if (playerPlaying > 1) playerPlaying = 0;
    }

    public Texture getPlayerTexture()
    {
        return players[playerPlaying];
    }

    public int gameOver()
    {
        //first horizontal
        if (matrix[0] == matrix[1] && matrix[1] == matrix[2] && matrix[0] != -1) return matrix[0];
        //second horizontal
        if (matrix[3] == matrix[4] && matrix[4] == matrix[5] && matrix[3] != -1) return matrix[3];
        //third horizontal
        if (matrix[6] == matrix[7] && matrix[7] == matrix[8] && matrix[6] != -1) return matrix[6];
        //first vertical
        if (matrix[0] == matrix[3] && matrix[3] == matrix[6] && matrix[0] != -1) return matrix[0];
        //second vertical
        if (matrix[1] == matrix[4] && matrix[4] == matrix[7] && matrix[1] != -1) return matrix[1];
        //third vertical
        if (matrix[2] == matrix[5] && matrix[5] == matrix[8] && matrix[2] != -1) return matrix[2];
        //diagonals
        if (matrix[0] == matrix[4] && matrix[4] == matrix[8] && matrix[0] != -1) return matrix[0];
        if (matrix[2] == matrix[4] && matrix[4] == matrix[6] && matrix[2] != -1) return matrix[2];

        return -1;
    }
}
