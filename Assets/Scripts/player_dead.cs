using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_dead : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("bomb_enemy"))
        {
            Destroy(this.gameObject);
        }

        if(collision.gameObject.CompareTag("power_up"))
        {
            Destroy(collision.gameObject);
            score_manager.instance.addPoints();

        }
    }
}
