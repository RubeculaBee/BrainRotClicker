using Godot;
using System;

public partial class GameManager : Node
{
    public static int score = 0;
    private Label scoreDisplay;

    public override void _Ready()
    {
        scoreDisplay = GetChild<Label>(1);
    }

    public override void _Process(double delta)
    {
        scoreDisplay.Text = $"Rot: {score}";
    }
}