using UnityEngine;
using System.Collections;

public class playerclicked : MonoBehaviour
{

    public boardGame myGame;
    public int position = 0;

    // Use this for initialization
    void Start()
    {
        myGame = GameObject.FindObjectOfType<boardGame>();
    }

    public void OnMouseDown()
    {
        var myRenderer = this.gameObject.GetComponent<Renderer>() as Renderer;

        myRenderer.material.SetTexture("_MainTex", myGame.getPlayerTexture());
        myGame.playerPlayed(position);
    }
}
