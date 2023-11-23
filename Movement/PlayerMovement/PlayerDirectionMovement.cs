class PlayerDirectionMovement : IDirectable
{
    private IDirectionControl control;
    
    public PlayerDirectionMovement(IDirectionControl control)
    {
        this.control = control;
    }

    public void DirectionalMove()
    {
        throw new System.NotImplementedException();
    }
}