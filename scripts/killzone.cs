using Godot;
using System;

public partial class killzone : Area2D
{
    private Timer _timer = new();
    
    public override void _Ready()
    {
        _timer = GetNode<Timer>("Timer");
    }

    private void OnBodyEntered(PhysicsBody2D body){
        body.GetNode<AnimatedSprite2D>("playerSprite").Stop();
        body.GetNode("CollisionShape2D").QueueFree();

        GD.PrintRich("[shake]GAME OVER[/shake]");
        Engine.TimeScale= 0.5;
        _timer.Start();
    }

    private void OnTimeout(){
        GetTree().ReloadCurrentScene();
        Engine.TimeScale=1;
    }
    
}
