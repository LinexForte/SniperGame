using UnityEngine;

public abstract class Character : MonoBehaviour, IAimable
{
    private CharacterFacade facade;
    private IHitable hitable;

    protected void Initalize(IMoveable moveable, IShootable shootable, IInteractable interactable, IHitable hitable)
    {
        facade = new CharacterFacade(moveable, shootable, interactable);
        this.hitable = hitable;
    }

    private void Update()
    {
        facade.Update();
    }

    public void Hit(Hit hit)
    {
        hitable.ApplyHit(hit);
    }
}