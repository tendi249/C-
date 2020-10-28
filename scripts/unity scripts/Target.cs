using UnityEngine;

public class Target : MonoBehaviour
{
    public float Health = 50f;

    public GameObject boxthing;

    public void TakeDamage (float amount)
    {
        Health -= amount;
        if (Health <= 0f)
        {
            Die();
        }
    }

    void Die ()
    {
        Instantiate(boxthing, transform.position, transform.rotation);
        Destroy(gameObject);
    }

}
