using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameObject playerSpawner;

    void OnCollisionEnter(Collision collision)
    {
        // Убедитесь, что столкнувшийся объект - это игровой персонаж
        if (collision.gameObject.CompareTag("Player"))
        {
            // Принудительно убиваем игрока
            deathPlayer();
        }
    }

    private void deathPlayer()
    {
        Destroy(gameObject);

        // Находим playerSpawner и запускаем создание нового игрока
        if (playerSpawner != null)
        {
            GameObject newPlayer = Instantiate(playerSpawner.gameObject, playerSpawner.transform.position, playerSpawner.transform.rotation);
        }
    }
}
