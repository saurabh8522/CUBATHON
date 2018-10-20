using UnityEngine;

public class playercollision : MonoBehaviour {
    public Playermovement movement;
    void OnCollisionEnter (Collision collisionInfo)
    {
        if(collisionInfo.collider.tag=="obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }
    }

}
