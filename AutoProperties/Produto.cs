using System.Globalization;
namespace Course
{
    class Produto
    {
        //OBS: GET é responsável por receber os valores.
        //OBS: SET é responsável por alterar esses valores.
        //As AUTO PROPERTIES é uma proposta para melhorar ainda mais como podemos implementar o encapsulamento
        //AUTO PROPERTIES ou PROPRIEDADES AUTOIMPLEMENTADAS: É uma forma simplificada de se declarar propriedades que não necessitam de lógicas particulares para as operações GET e SET.
        private string _nome;//Atributos privativos
        public double Preco { get; private set; } //Aqui utilizamos o método GET pois queremos obter um preço, porém utilizamos o PRIVATE SET, pois não queremos que outras classes possam alterar o valor desse preço.
        //As AUTO PROPERTIES POSSIBILITAM que ao invés de criar o atributo e depois criar uma propriedade para isso, podemos em uma única linha definir a propriedade e definir o get e o set de forma privativa ou não.
        public int Quantidade { get; private set; }

        //Atalho: Ao invés de digitar tudo podemos apenas digitat "prop" e apertar TAB TAB para que o programa auto complete.

        public Produto()
        {
        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        
        //Nesse caso não foi possível utilizar uma AUTOPROPERTIES no nome pois ele possui uma lógica personalizada para ele.
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1) //Value utiliza o parâmetro que será utilizado na operação da propriedade sem a necessidade de declarar uma variável para receber o parâmetro de entrada da operação
                {
                    _nome = value;
                }
            }
        }
   
        public double ValorTotalEmEstoque
        {
            get { return Preco * Quantidade; }
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}