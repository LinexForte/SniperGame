public interface IControl : IMovementControl, IShootmentControl, IInteractmentControl
{
    void LoadSettings(ControlSettings settings);
}
