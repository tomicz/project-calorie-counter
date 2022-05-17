using UnityEngine;
using TMPro;
using TOMICZ.Data;
using System.Collections.Generic;

namespace TOMICZ.UI
{
    public enum InputField
    {
        Article,
        Brand,
        Calories,
        Fats,
        Carbohydrates,
        Proteins
    }

    public class AddArticlePanel : MonoBehaviour
    {
        [SerializeField] private List<TMP_InputField> _inputFieldsList = new List<TMP_InputField>();

        public void AddItem()
        {
            if (IsInputFieldNotEmpty())
            {
                CreateNewArticleDataObject
                (
                    Get(InputField.Article).text,
                    Get(InputField.Brand).text,
                    float.Parse(Get(InputField.Calories).text),
                    float.Parse(Get(InputField.Fats).text),
                    float.Parse(Get(InputField.Carbohydrates).text),
                    float.Parse(Get(InputField.Proteins).text)
                );
            }

        }

        private void CreateNewArticleDataObject(string articleName, string brandName, float caloriesAmount, float fatsAmount, float carbohydratesAmount, float proteinsAmount)
        {
            ArticleData article = new ArticleData(articleName, brandName, caloriesAmount, fatsAmount, carbohydratesAmount, proteinsAmount);
            Debug.Log("Successfully created a new article object");
        }

        private bool IsInputFieldNotEmpty()
        {
            foreach(var field in _inputFieldsList)
            {
                if(field == null)
                {
                    Debug.Log(field.name + " GameObject is missing.");
                    return false;
                }
                else if(field.text == "")
                {
                    Debug.Log(field.name + " text area is empty.");
                    return false;
                }
            }

            return true;
        }

        public TMP_InputField Get(InputField inputFields)
        {
            switch (inputFields)
            {
                case InputField.Article:
                    return _inputFieldsList[0];
                case InputField.Brand:
                    return _inputFieldsList[1];
                case InputField.Calories:
                    return _inputFieldsList[2];
                case InputField.Fats:
                    return _inputFieldsList[3];
                case InputField.Carbohydrates:
                    return _inputFieldsList[4];
                case InputField.Proteins:
                    return _inputFieldsList[5];
            }

            return null;
        }
    }
}