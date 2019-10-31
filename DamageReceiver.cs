using UnityEngine;

public class DamageReceiver : MonoBehaviour
{
    UnityEngine.Events.UnityEvent onDeath;

    [SerializeField] int hitpoints = 10;

    int currentHitpoints;

    private void Awake()
    {
        currentHitpoints = hitpoints;
    }
    public void TakeDamage(int damageAmount)
    {
        currentHitpoints -= damageAmount;

        if (currentHitpoints <= 0)
        {
            if (onDeath != null)
            {
                onDeath.Invoke();
            }
            Destroy(gameObject);
        }
    }
}