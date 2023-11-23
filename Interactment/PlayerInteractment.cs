public class PlayerInteractment : Interactment
{
    private IInteractmentControl control;

    public PlayerInteractment(IInteractmentControl control)
    {
        this.control = control;
    }

    public override void Interact()
    {
        throw new System.NotImplementedException();
    }
}