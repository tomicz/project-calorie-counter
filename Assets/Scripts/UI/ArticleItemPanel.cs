using System.Collections.Generic;
using TOMICZ.Data;
using UnityEngine;
using TMPro;

namespace TOMICZ.UI
{
    public class ArticleItemPanel : MonoBehaviour
    {
        public ArticleData articleData;

        public void SetData(ArticleData articleData) => this.articleData = articleData;
    }
}