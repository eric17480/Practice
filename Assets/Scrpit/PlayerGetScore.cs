using UnityEngine;

public class PlayerGetScore : MonoBehaviour
{
    public GameManager gameManager;

    void TouchObject(Collider other)
    {
        Debug.Log("Triggered with: " + other.name);
        if (other.CompareTag("Collectible")) // Collectible 為指定物件的標籤
        {
            gameManager.AddScore(1);
            Destroy(other.gameObject); // 碰撞後銷毀物件
        }
        
    }
}

