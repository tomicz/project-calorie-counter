using System.Collections.Generic;
using TOMICZ.Data;
using UnityEngine;

namespace TOMICZ.UI
{
    public class ArticleItemPanel : Panel
    {
        [SerializeField] private List<ArticleItemCellPanel> _articleItemCellsList = new List<ArticleItemCellPanel>();

        public void SetData(ArticleData articleData)
        {
            _articleItemCellsList[(int)InputField.Article].SetValue(articleData.articleName);
            _articleItemCellsList[(int)InputField.Brand].SetValue(articleData.brandName);
            _articleItemCellsList[(int)InputField.Calories].SetValue(articleData.calories);
            _articleItemCellsList[(int)InputField.Fats].SetValue(articleData.fats);
            _articleItemCellsList[(int)InputField.Carbohydrates].SetValue(articleData.carbohydrates);
            _articleItemCellsList[(int)InputField.Proteins].SetValue(articleData.proteins);
        }
    }
}