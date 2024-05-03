using Godot;

public partial class coin : Area2D
{
	GameManager gameManager;
	AnimationPlayer animationPlayer;

    public override void _Ready()
    {
		gameManager = GetNode<GameManager>("%GameManager");
		animationPlayer = GetNode<AnimationPlayer>("AnimationPlayer");
    }

    private void OnBodyEntered(PhysicsBody2D body)
	{
		GD.PrintRich("[pulse]I'm a Coin!![/pulse]");
		gameManager.AddPoints();
		animationPlayer.Play("pickup");
	}
}
