namespace lab.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public char Genero { get; set; }
        public string Curso { get; set; }
        private List<Aluno> listaAluno { get; set; }


        public void CriarAluno()
        {
            listaAluno = new List<Aluno>()
            {   new Aluno(){ Id = 1,Nome= "Vinícius",Idade=28, Genero = 'M', Curso="Análise e Desenvolvimento de Sistemas"},
                new Aluno(){ Id = 2,Nome= "Gabriel",Idade=24, Genero = 'M', Curso="Medicina"},
                new Aluno(){ Id = 3,Nome= "Rafaela",Idade=22, Genero = 'F', Curso="Direito - Eca"},
                new Aluno(){ Id = 4,Nome= "Neemias",Idade=21, Genero = 'M', Curso="Faculdade da Vida"}
            };
        }

        public List<Aluno> BuscarAluno()
        {
            return listaAluno;
        }
    }
}