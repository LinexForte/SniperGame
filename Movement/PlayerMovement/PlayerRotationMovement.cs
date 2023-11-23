class PlayerRotationMovement : IRotateable
{
    private IRotationControl control;

    public PlayerRotationMovement(IRotationControl control)
    {
        this.control = control;
    }

    public void RotationalMove()
    {
        throw new System.NotImplementedException();
    }
}