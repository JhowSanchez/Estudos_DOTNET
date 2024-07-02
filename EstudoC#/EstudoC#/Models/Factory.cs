namespace EstudoC_.Models
{
    public class Factory
    {
        public static ILimpar Get(TipoAnimal tipoAnimal)
        {
            if (TipoAnimal.Cachorro == tipoAnimal)
                return new LimparCachorro();
            else if(TipoAnimal.Passarinho == tipoAnimal)
                return new LimparPassarinho();
            else
                return new LimparGato();
        }
    }
}
