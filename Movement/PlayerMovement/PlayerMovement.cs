public class PlayerMovement : Movement
{
    private IDirectable directable;
    private IRotateable rotateable;

    public PlayerMovement(IMovementControl control)
    {
        directable = new PlayerDirectionMovement(control);
        rotateable = new PlayerRotationMovement(control);
    }

    public override void Move()
    {
        directable.DirectionalMove();
        rotateable.RotationalMove();
    }
}