using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Movement movement;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManage>().EndGame();
        }
    }

    // Update is called once per frame
    //void Update()
    //{
        
   // }
}
