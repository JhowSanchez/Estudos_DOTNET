namespace EstudoC_.Models
{
    public abstract class Pessoa
    {
        private String _Nome;
        private int _Idade;
        private string _Sobrenome;

        public String Nome
        {

            get => _Nome;


            set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentNullException("Nome não pode ser vazio");

                }
                _Nome = value;
            }
        }
        public int Idade
        {
            get => _Idade;

            set
            {
                if (value == null || value <= 0)
                    throw new ArgumentNullException("Idade invalida");

                _Idade = value;
            }
        }

        public string Sobrenome
        {
            get => _Sobrenome;

            set
            {
                if (value == null || value == "")
                    throw new ArgumentNullException("Sobrenome invalido");

                _Sobrenome = value;
            }
        }


        public Pessoa()
        {
        }

        public Pessoa(String nome, String Sobrenome, int idade)
        {
            _Nome = nome;
            _Idade = idade;
            _Sobrenome = Sobrenome;
        }

        public void Deconstruct(out string nome,out string sobrenome ,out int idade)
        {
            nome = Nome;
            sobrenome = Sobrenome;
            idade = Idade;
        }
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos ");
        }

        public abstract void TESTE();

        public string NomeCompleto => $"{Nome} {Sobrenome}";

        public override string ToString()
        {
            return $"{_Nome} {_Sobrenome} {_Idade}";
        }
        public class PessoaBiulder()
        {
            private String Nome;
            private int idade;
            private String Sobrenome;

            public Pessoa Biulder()
            {
                return new Pessoa
                {
                    Nome = this.Nome,
                    Sobrenome = this.Sobrenome,
                    Idade = this.idade
                };
            }

            public PessoaBiulder SetNome(String nome)
            {
                this.Nome = nome;
                return this;
            }

            public PessoaBiulder SetIdade(int idade)
            {
                this.idade = idade;
                return this;
            }

            public PessoaBiulder SetSobrenome(String sobrenome)
            {
                {
                    this.Sobrenome = sobrenome;
                    return this;
                }
            }

        }
    }
}
