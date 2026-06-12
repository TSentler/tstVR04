using System.Collections.Generic;
using UnityEngine;

public class PotionSystem : MonoBehaviour
{
    public PotionSpawner Spawner;
    public Cauldron cauldron;

    public GameObject mushroom;
    public GameObject watermelon;

    public void BrewPotion()
    {
        List<IngredientType> ingredients = cauldron.currentIngredients;
        // vision potion
        if (ingredients.Contains(IngredientType.Mushroom) &&
            ingredients.Contains(IngredientType.Water) &&
            ingredients.Count == 2)
        {
            Debug.Log("Vision potion worked!");
            Spawner.Spawn(mushroom);
        }
        else if (ingredients.Contains(IngredientType.Watermelon) &&
            ingredients.Contains(IngredientType.Eye) &&
            ingredients.Contains(IngredientType.Bone) &&
            ingredients.Count == 3)
        {
            Debug.Log("strong potion worked!");
            Spawner.Spawn(watermelon);
        }
        else if (ingredients.Contains(IngredientType.Water) &&
            ingredients.Contains(IngredientType.Eye) &&
            ingredients.Contains(IngredientType.Mushroom) &&
            ingredients.Count == 3)
        {
            Debug.Log("tired potion worked!");
        }
        else if (ingredients.Contains(IngredientType.Mushroom) &&
            ingredients.Contains(IngredientType.Bone) &&
            ingredients.Count == 2)
        {
            Debug.Log("happy potion worked!");
        }
        else if (ingredients.Contains(IngredientType.Watermelon) &&
            ingredients.Contains(IngredientType.Mushroom) &&
            ingredients.Contains(IngredientType.Bone) &&
            ingredients.Count == 3)
        {
            Debug.Log("sad potion worked!");
        }
        else 
        {
            Debug.Log("Error!");
        }
        cauldron.ClearCauldron();
    }
}
