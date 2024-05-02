using Godot;

public partial class coin : Area2D
{
	private void OnBodyEntered(PhysicsBody2D body)
	{
		GD.PrintRich("[pulse]I'm a Coin!![/pulse]");
		using (GameManager gm = new())
		{
			gm.AddPoints();
		}
		QueueFree();
	}
}
