using UnityEngine;
using TMPro;

namespace TOMICZ.UI
{
    public class ArticleItemCellPanel : MonoBehaviour
    {
        [SerializeField] private TMP_Text _cellValueLabel;

        public void SetValue(string value) => _cellValueLabel.text = value;

        public void SetValue(float value) => _cellValueLabel.text = value.ToString();
    }
}