struct Article
{
    public string nom;
    public decimal prix;
    public int quantite;

    public Article(string nom, decimal prix, int quantite)
    {
        this.nom = nom;
        this.prix = prix;
        this.quantite = quantite;
    }

    public void Afficher()
    {
        Console.WriteLine("Nom: {0}, Prix: {1}, Quantité: {2}", nom, prix, quantite);
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