namespace ModeloAnemico.Model
{
    public sealed class Cliente
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Endereco { get; private set; }

        public Cliente(int id, string nome, string endereco)
        {
            Validar(id, nome, endereco);
            Id = id;
            Nome = nome;
            Endereco = endereco;
        }

        public void Update(int id, string nome, string endereco)
        {
            Validar(id, nome, endereco);
            Id = id;
            Nome = nome;
            Endereco = endereco;
        }

        public static void Validar(int id, string nome, string endereco)
        {

            if (id < 0)
            {
                throw new InvalidOperationException("Erro, o Id é menor que 0");//Exceção de operação invalida.
            }

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(endereco))
            {
                throw new ArgumentException("O nome é requerido");
            }

            if (nome.Length < 3)
            {
                throw new ArgumentException("O nome deve ter no minimo 3 caracteres");
            }

            if (nome.Length > 100)
            {
                throw new ArgumentException("O nome excedeu 100 caracteres");
            }

        }

    }
}