using UnityEngine;

public class CollisionGameOver : MonoBehaviour
{
    public GameManager gameManager;

    private void OnCollisionEnter2D(Collision2D col)
    {
        gameManager.GameOverSequence();
        // code in try again screen
    }
}