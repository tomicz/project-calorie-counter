using TOMICZ.Data;
using UnityEngine;

namespace TOMICZ.UI
{
    public class ArticleManager : MonoBehaviour
    {
        private void Awake()
        {
            AddArticlePanel.OnArticleItemPanelCreatedEvent += OnArticleItemPanelCreated;
        }

        private void OnDestroy()
        {
            AddArticlePanel.OnArticleItemPanelCreatedEvent -= OnArticleItemPanelCreated;
        }

        private void OnArticleItemPanelCreated(string articleName, string brandName, float calories, float fats, float carbohydrates, float protein)
        {
            ArticleData articleData = new ArticleData(articleName, brandName, calories, fats, carbohydrates, protein);
        }
    }
}