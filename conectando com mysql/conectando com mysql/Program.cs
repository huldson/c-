using System;
using System.Data;

using MySql.Data.MySqlClient;

namespace conectando_com_mysql
{
    class Pessoa
    {
        public Pessoa (string nome,int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        public string Nome { get; set; }
        public int Idade { get; set; } 

        public void create(MySqlConnection bdConn) {
           
            MySqlCommand comm1 = new MySqlCommand("INSERT INTO pessoa (idade,nome) VALUES ("+Idade+",'"+Nome+"' ) ", bdConn);
            comm1.ExecuteNonQuery();
        }
        

    }


    class Program
    {


        static void Main(string[] args)
             
        {
            MySqlDataReader reader = null;
            //Define string de conexão
            MySqlConnection bdConn = new MySqlConnection("server=localhost;database=cadastro;uid=root;pwd=''");

            bdConn.Open();
            Console.WriteLine("digite sua idade: ");
             int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("escreva seu nome: ");
            string nome = Console.ReadLine();
            Pessoa pessoa2 = new Pessoa(nome,idade);
            pessoa2.create(bdConn);
            
            //Verifica se a conexão está aberta

                //Se estiver aberta insere os dados na BD
            /*  MySqlCommand commS = new MySqlCommand("SELECT * FROM personagens ", bdConn);
            reader = commS.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("{0}",
                    reader["name"]                    );
            }
        */
        Console.WriteLine("Hello World!");
        }
    }
}
