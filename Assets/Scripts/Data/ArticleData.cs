public class ArticleData
{
    public string articleName = "article name";
    public string brandName = "brand name";
    public float calories = 0;
    public float fats = 0;
    public float carbohydrates = 0;
    public float proteins = 0;

    public ArticleData(string articleName, string brandName, float calories, float fats, float carbohydrates, float proteins)
    {
        this.articleName = articleName;
        this.brandName = brandName;
        this.calories = calories;
        this.fats = fats;
        this.carbohydrates = carbohydrates;
        this.proteins = proteins;
    }
}