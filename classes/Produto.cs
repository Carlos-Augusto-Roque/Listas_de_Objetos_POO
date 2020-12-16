namespace Listas_de_Objetos_POO.classes
{
    public class Produto
    {
        //metodos acessores para receber os valores nos atributos
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        //método construtor vazio
        public Produto(){

        }

        //método construtor com todos os atributos da classe
        public Produto(int _codigo, string _nome, float _preco){
            this.Codigo = _codigo;
            this.Nome = _nome;
            this.Preco = _preco;
        }
       
    }
}