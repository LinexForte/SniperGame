using System;
using UnityEngine;

public class Health : IDamageable, ISaveableData, IDiedObservable, IDamagedObservable, IHealthChangedObservable
{
    private int minHealth;
    private int maxHealth;
    private int amount;
    private event Action<int> HealthChanged;
    private event Action Died;
    private event Action<int> Damaged;

    public Health(int minHealth, int maxHealth)
    {
        this.minHealth = minHealth;
        this.maxHealth = maxHealth;
        this.amount = maxHealth;
    }

    private int Amount 
    { 
        get 
        {
            return amount;
        } 
        set 
        { 
            if (value <= maxHealth)
            {
                if (value > minHealth)
                {
                    amount = value;
                }
                else
                {
                    amount = minHealth;
                    Died.Invoke();
                }
            }
            else
            {
                amount = maxHealth;
            }

            HealthChanged.Invoke(amount);
        } 
    }

    public void ApplyDamage(int damage)
    {
        if (damage >= 0)
        {
            Amount -= damage;
            Damaged.Invoke(damage);
        }
        else
        {
            Debug.LogError("TryedApplyNegativeDamage");
        }
    }

    public string Save()
    {
        throw new NotImplementedException();
    }

    public void Load(string data)
    {
        throw new NotImplementedException();
    }

    public void Subscribe(IDiedObserver listener)
    {
        Died += listener.OnDie;
    }

    public void Unsubscribe(IDiedObserver listener)
    {
        Died -= listener.OnDie;
    }

    public void Subscribe(IDamagedObserver listener)
    {
        Damaged += listener.OnTakeDamage;
    }

    public void Unsubscribe(IDamagedObserver listener)
    {
        Damaged -= listener.OnTakeDamage;
    }

    public void Subscribe(IHealthChangedObserver listener)
    {
        HealthChanged += listener.OnStatChange;
    }

    public void Unsubscribe(IHealthChangedObserver listener)
    {
        HealthChanged -= listener.OnStatChange;
    }
}
