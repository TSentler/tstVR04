using System.Collections.Generic;
using UnityEngine;

public class Cauldron : MonoBehaviour
{
    public List<IngredientType> currentIngredients = new List<IngredientType>();
    
    private void OnTriggerEnter(Collider other)
    {
        Ingredient ingredient = other.GetComponent<Ingredient>();

        if (ingredient != null)
        {
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
