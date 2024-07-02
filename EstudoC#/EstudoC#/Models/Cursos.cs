namespace EstudoC_.Models
{
    public class Cursos
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public Cursos() { }
        
        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
    
        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public int QuantidadeAlunos()
        {
            return Alunos.Count;
        }
    }
}
