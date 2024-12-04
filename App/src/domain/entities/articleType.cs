namespace domain.entities 
{
    public enum Type
    {
        Alimentaire,
        Droguerie,
        Habillement,
        Loisir,
        Autre
    };

    public class ArticleType : Article
    {
        public Type type { get; set; }


        public ArticleType(string nom, decimal prix, int quantite, Type type) : base(nom, prix, quantite)
        {
            this.type = type;
        }

        //new public void Afficher()
        //{
        //    Console.WriteLine($"Article : {nom}, Prix : {prix}, Quantité : {quantite}, Type : {type}");
        //}
    }
}
