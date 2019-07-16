
using UnityEngine;

public class collisionPlayer : MonoBehaviour
{
    public playerMovement movement;
   
   void OnCollisionEnter (Collision collisionInfo )
    {
        if (collisionInfo.collider.tag == "Obstacle"   )
        {
            movement.enabled = false;
            FindObjectOfType<gameManager>().EndGame();
        }

        if (collisionInfo.collider.tag == "END")
        {
            movement.enabled = false;
            
        }
    }
}
