using Godot;
using System;

public partial class ShopItem : PanelContainer
{
    private Label purchaseCountLabel;
    private Button button;

    [Export]
    private String name;
    [Export]
    private String description;
    [Export]
    private int price;

    private int purchaseCount;

    public override void _Ready()
    {
        GetNode<Label>("HBoxContainer/Name-Description/Name").Text = name;
        GetNode<Label>("HBoxContainer/Name-Description/Description").Text = description;
        GetNode<Label>("HBoxContainer/Price-PurchaseCount/Price").Text = $"ℝ{price}";

        purchaseCountLabel = GetNode<Label>("HBoxContainer/Price-PurchaseCount/PurchaseCount");
    }
}
