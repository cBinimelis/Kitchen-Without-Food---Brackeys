using Godot;
using System;

public partial class coin : Area2D
{
	private void OnBodyEntered(PhysicsBody2D body)
	{
		GD.PrintRich("[pulse]I'm a Coin!![/pulse]");
		QueueFree();
	}
}
