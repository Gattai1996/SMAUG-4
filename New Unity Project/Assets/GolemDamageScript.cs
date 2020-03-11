using UnityEngine;

public class GolemDamageScript : MonoBehaviour
{

    public float health = 30f;
    public void TakeDamage(float damage)
    {
        health -= damage;
        Debug.Log("Health Remaining= " + health);

        if(health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
