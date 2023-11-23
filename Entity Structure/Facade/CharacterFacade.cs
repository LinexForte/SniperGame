public class CharacterFacade
{
    private IMoveable moveable;
    private IShootable shootable;
    private IInteractable interactable;

    public CharacterFacade(IMoveable moveable, IShootable shootable, IInteractable interactable)
    {
        this.moveable = moveable;
        this.shootable = shootable;
        this.interactable = interactable;
    }

    public void Update()
    {
        moveable.Move();
        shootable.Shoot();
        interactable.Interact();
    }
}