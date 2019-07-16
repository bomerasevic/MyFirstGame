using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public gameManager game;

    void OnTriggerEnter ()
    {
        
        game.CompleteLevel();
    }
}
