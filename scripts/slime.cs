using Godot;
using System;


public partial class slime : Node2D
{
	const float SPEED = 40;
	int direction = 1;
	RayCast2D rayCastR;
	RayCast2D rayCastL;
	AnimatedSprite2D slimeSprite;

	public override void _Ready()
	{
		rayCastR = GetNode<RayCast2D>("RayCastR");
		rayCastL = GetNode<RayCast2D>("RayCastL");
		slimeSprite = GetNode<AnimatedSprite2D>("SlimeSprite");
	}
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Vector2 position = Position;

		if (rayCastR.IsColliding())
		{
			direction = -1;
			slimeSprite.FlipH = true;
		}
		else if (rayCastL.IsColliding())
		{
			direction = 1;
			slimeSprite.FlipH = false;
		}

		position.X += direction * SPEED * (float)delta;
		Position = position;
	}
}
