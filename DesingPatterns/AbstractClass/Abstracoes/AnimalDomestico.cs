namespace DesingPatterns.AbstractClass.Abstracoes
{
    public abstract class AnimalDomestico: Animal
    {
        public virtual string Nome {  get; set; }
        public abstract void Comer();
        public abstract void Beber(string liquido);
        public AnimalDomestico(string nome)
        {
            Nome = nome;
        }
        public AnimalDomestico()
        {
        }
    }
}
