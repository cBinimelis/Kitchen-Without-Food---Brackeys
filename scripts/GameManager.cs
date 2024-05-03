using Godot;
using System;

public partial class GameManager : Node
{
    public static int score = 0;
    Label scoreLabel;

    public override void _Ready()
    {
        scoreLabel = GetNode<Label>("scoreLabel");
    }

    public void AddPoints(){
        score +=1;
        scoreLabel.Text = $"You collected {score} coins.";
        GD.Print(score);
    }
}
