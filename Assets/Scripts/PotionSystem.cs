using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PotionSystem : MonoBehaviour
{
    public PotionSpawner Spawner;
    public Cauldron cauldron;
    public GameManager gameManager;

    public List<IngredientType> currentRecipe = new List<IngredientType>();

    public TMP_Text recipeText;

    int recipeIndex;

    void Start()
    {
        SetRandomRecipe();
    }

    void SetRandomRecipe()
    {
        currentRecipe.Clear();

        recipeIndex = Random.Range(0,4);
       
        if (recipeIndex == 0)
        {
            currentRecipe.Add(IngredientType.Mushroom);
            currentRecipe.Add(IngredientType.Water);

            recipeText.text = "Для зелья понадобится:\r\n\r\nгриб\r\nвода";
        }

        else if (recipeIndex == 1)
        {
             currentRecipe.Add(IngredientType.Watermelon);
             currentRecipe.Add(IngredientType.Eye);
             currentRecipe.Add(IngredientType.Bone);

             recipeText.text = "Для зелья понадобится:\r\n\r\nарбуз\r\nглаз\r\nкость";
        }

        else if (recipeIndex == 2)
        {
             currentRecipe.Add(IngredientType.Water);
             currentRecipe.Add(IngredientType.Eye);
             currentRecipe.Add(IngredientType.Mushroom);

             recipeText.text = "Для зелья понадобится:\r\n\r\nвода\r\nглаз\r\nгриб";
        }

        else if (recipeIndex == 3)
        {
             currentRecipe.Add(IngredientType.Mushroom);
             currentRecipe.Add(IngredientType.Bone);

             recipeText.text = "Для зелья понадобится:\r\n\r\nгриб\r\nкость";
        }

        else if (recipeIndex == 4)
        {
             currentRecipe.Add(IngredientType.Watermelon);
             currentRecipe.Add(IngredientType.Mushroom);
             currentRecipe.Add(IngredientType.Bone);

             recipeText.text = "Для зелья понадобится:\r\n\r\nарбуз\r\nгриб\r\nкость";
        }
        

        
    }

    public GameObject mushroom; 
    public GameObject watermelon;
    public GameObject wind;

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
            SetRandomRecipe();
            gameManager.AddScore();
        }
        //strong potion
        else if (ingredients.Contains(IngredientType.Watermelon) &&
            ingredients.Contains(IngredientType.Eye) &&
            ingredients.Contains(IngredientType.Bone) &&
            ingredients.Count == 3)
        {
            Debug.Log("strong potion worked!");
            Spawner.Spawn(watermelon);
            SetRandomRecipe();
            gameManager.AddScore();
        }
        //tired potion
        else if (ingredients.Contains(IngredientType.Water) &&
            ingredients.Contains(IngredientType.Eye) &&
            ingredients.Contains(IngredientType.Mushroom) &&
            ingredients.Count == 3)
        {
            Debug.Log("tired potion worked!");
            Spawner.Spawn(wind);
            SetRandomRecipe();
            gameManager.AddScore();
        }
        //happy potion
        else if (ingredients.Contains(IngredientType.Mushroom) &&
            ingredients.Contains(IngredientType.Bone) &&
            ingredients.Count == 2)
        {
            Debug.Log("happy potion worked!");

            SetRandomRecipe();
            gameManager.AddScore();
        }
        //sad potion
        else if (ingredients.Contains(IngredientType.Watermelon) &&
            ingredients.Contains(IngredientType.Mushroom) &&
            ingredients.Contains(IngredientType.Bone) &&
            ingredients.Count == 3)
        {
            Debug.Log("sad potion worked!");

            SetRandomRecipe();
            gameManager.AddScore();
        }
        else 
        {
            Debug.Log("Error!");
            SetRandomRecipe();
            gameManager.RemoveScore();
        }
        cauldron.ClearCauldron();
    }
}
