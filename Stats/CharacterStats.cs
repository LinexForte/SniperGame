using UnityEngine;

public abstract class CharacterStats : ScriptableObject
{
    [SerializeField] private int minHealth;
    [SerializeField] private int maxHealth;

    public int MinHealth => minHealth;
    public int MaxHealth => maxHealth;
}