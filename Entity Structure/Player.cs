using UnityEngine;

public class Player : Character
{
    [SerializeField] private ControlSettings controlSettings;
    [SerializeField] private PlayerStats stats;

    private void OnEnable()
    {
        IControl control = new KeyboardControl(controlSettings);
        IDamageable damageable = new Health(stats.MinHealth, stats.MaxHealth);
        IMoveable moveable = new PlayerMovement(control);
        IShootable shootable = new PlayerShootment(control);
        IInteractable interactable = new PlayerInteractment(control);
        IHitable hitable = new PlayerHitment(damageable);

        Initalize(moveable, shootable, interactable, hitable);
    }
}