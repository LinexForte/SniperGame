public class PlayerHitment : Hitment
{
    private IDamageable damageable;

    public PlayerHitment(IDamageable damageable)
    {
        this.damageable = damageable;
    }

    public override void ApplyHit(Hit hit)
    {
        damageable.ApplyDamage(0);
        throw new System.NotImplementedException();
    }
}