public class ParentTrigger : PlayerTrigger
{
    private void Awake()
    {
        OnPlayerEnter += EnterHandler;
        OnPlayerExit += ExitHandler;
    }

    public void EnterHandler(Player player)
    {
        player.transform.parent = transform;
    }

    public void ExitHandler(Player player)
    {
        player.transform.parent = null;
    }
}
