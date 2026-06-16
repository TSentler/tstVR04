using System.Collections.Generic;
using UnityEngine;

public class Cauldron : MonoBehaviour
{
    public PotionSystem potionSystem;
    public List<IngredientType> currentIngredients = new List<IngredientType>();
    
    private void OnTriggerEnter(Collider other)
    {
        Ingredient ingredient = other.GetComponent<Ingredient>();

        if (ingredient != null)
        {
            if (!potionSystem.currentRecipe.Contains(ingredient.type))
            {
                Debug.Log("Этот ингридиент не нужен!");
                return;
            }

            currentIngredients.Add(ingredient.type);
            Debug.Log("Добавлен:" + ingredient.type);

            other.gameObject.SetActive(false);
        }
    }

    public void ClearCauldron()
    {
        currentIngredients.Clear();
        Debug.Log("Котел очищен");
    }
}
