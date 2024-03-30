public class WaterTrigger : PlayerTrigger
{
    private void Awake()
    {
        OnPlayerEnter += EnterHandler;
        OnPlayerExit += ExitHandler;
    }

    public void EnterHandler(Player player)
    {
        player.SetWaterState(true);
    }

    public void ExitHandler(Player player)
    {
        player.SetWaterState(false);
    }
}
