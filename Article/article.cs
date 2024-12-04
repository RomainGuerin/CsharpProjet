public class Article
{
    public string nom { get; set; }
    public decimal prix { get; set; }
    public int quantite { get; set; }

    public Article(string nom, decimal prix, int quantite)
    {
        this.nom = nom;
        this.prix = prix;
        this.quantite = quantite;
    }

    public void Afficher()
    {
        Console.WriteLine($"Article : {nom}, Prix : {prix}, Quantité : {quantite}");
    }

    public void Ajouter(int quantity)
    {
        if (quantity > 0)
        {
            quantite += quantity;
        }
        else
        {
            Console.WriteLine("La quantité à ajouter doit être un nombre entier positif.");
        }
    }

    public void Retirer(int quantity)
    {
        if (quantity > 0 && quantity <= quantite)
        {
            quantite -= quantity;
        }
        else
        {
            Console.WriteLine("Quantité invalide.");
        }
    }
}
