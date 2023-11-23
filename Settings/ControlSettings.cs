using UnityEngine;

public class ControlSettings : ScriptableObject
{
    [SerializeField] private KeyCode forward;
    [SerializeField] private KeyCode backward;
    [SerializeField] private KeyCode right;
    [SerializeField] private KeyCode left;
    [SerializeField] private KeyCode run;
    [SerializeField] private KeyCode crouch;
    [SerializeField] private KeyCode jump;
    [SerializeField] private KeyCode shoot;
    [SerializeField] private KeyCode scope;
    [SerializeField] private KeyCode reload;
    [SerializeField] private KeyCode changeSelectedItemNext;
    [SerializeField] private KeyCode changeSelectedItemPrev;
    [SerializeField] private KeyCode interact;
    [SerializeField] private KeyCode openMenu;

    public KeyCode Forward => forward;
    public KeyCode Backward => backward;
    public KeyCode Right => right;
    public KeyCode Left => left;
    public KeyCode Run => run;
    public KeyCode Crouch => crouch;
    public KeyCode Jump => jump;
    public KeyCode Shoot => shoot;
    public KeyCode Scope => scope;
    public KeyCode Reload => reload;
    public KeyCode ChangeSelectedItemNext => changeSelectedItemNext;
    public KeyCode ChangeSelectedItemPrev => changeSelectedItemPrev;
    public KeyCode Interact => interact;
    public KeyCode OpenMenu => openMenu;
}