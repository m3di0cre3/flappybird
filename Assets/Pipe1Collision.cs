using UnityEngine;

public class Pipe1Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log(col.gameObject);
        // code in try again screen
    }
}