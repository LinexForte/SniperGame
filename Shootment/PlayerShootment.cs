public class PlayerShootment : Shootment
{
    private IShootmentControl control;

    public PlayerShootment(IShootmentControl control)
    {
        this.control = control;
    }

    public override void Shoot()
    {
        throw new System.NotImplementedException();
    }
}