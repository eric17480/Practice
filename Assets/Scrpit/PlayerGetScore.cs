using UnityEngine;

public class PlayerGetScore : MonoBehaviour
{
    public GameManager gameManager;
    void TouchObject(Collider other)
    {
        Debug.Log("Triggered with: " + other.name);
        if (other.CompareTag("Collectible")) // Collectible 為指定物件的標籤
        {
            if (gameManager == null) //要先確認有抓到才能更新
                return;
            gameManager.AddScore();

            if (other.gameObject != null)
                Destroy(other.gameObject); // 碰撞後銷毀物件
        }
    }
}