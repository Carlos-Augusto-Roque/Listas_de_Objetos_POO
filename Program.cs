using System;
using System.Collections.Generic;
using Listas_de_Objetos_POO.classes;

namespace Listas_de_Objetos_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação da lista de objetos(produtos)
            List<Produto> produtos = new List<Produto>();

            // Cadastro dos produtos dentro da lista através
            // da instância com metodo construtor com todos atributos da classe
            produtos.Add(new Produto(0001,"Apple Watch", 2499f));
            produtos.Add(new Produto(0002,"Xiomi Watch",899f));
            produtos.Add(new Produto(0003,"Smartphone Xiomi",1899f));
            produtos.Add(new Produto(0004,"Samsumg S20",4899f));
            produtos.Add(new Produto(0005,"Iphone XR",3899f));


            //ou cadastro dos produtos dentro da lista a partir de instância básica
            Produto asus = new Produto();//instaciamento do objeto asus
            asus.Codigo = 0006;
            asus.Nome = "Asus note 10";
            asus.Preco = 2499f;
            produtos.Add(asus);//adicionado na lista de produtos

            //exibição da lista de produtoscom foreach
            foreach (var item in produtos){
                System.Console.WriteLine($"{item.Nome} - {item.Preco}");
            }

            //Remoção de um item da lista através de seu indice de array
            //linha removida na posicao 3 do array: Produto(Samsumg S20,4.899f)
            produtos.RemoveAt(3);

            //Remoção de um item da lista através do método RemoveAll e a expressão lambda
            //linha removida na posicao 1 do array: Produto("Xiomi Watch",899f)
            produtos.RemoveAll(x => x.Nome == "Xiomi Watch");

            //exibição da lista alterada (removido o item 3 - Samsumg S20 e o item 2 - Xiomi Watch)
            System.Console.WriteLine($"\nLista alterada:");
            foreach (var item in produtos)
            {
                System.Console.WriteLine($"{item.Nome} - {item.Preco}");
            }      

        }
    }
}
