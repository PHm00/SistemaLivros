using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Venda_Livros_PJ
{
    class Control
    {
        Model modelo;
        public int opcao;

        public Control()
        {
            this.modelo = new Model();//Criando uma chave            
            ConsultarOpcao = -1;
        }//Fim do construtor

        public int ConsultarOpcao
        {
            get { return this.opcao; }
            set { this.opcao = value; }
        }

        public void Menu()
        {


            Console.WriteLine("Escolha uma das opções abaixo: \n\n" +
                              "0. Login\n" +
                              "1. Cadastrar-se\n");
            opcao = Convert.ToInt32(Console.ReadLine());
            
            
   
                        
        }//Fim do menu
        
        
        
        
        
        public void Operacao()
        {
            Menu();//Mostrar o menu em tela
            switch (ConsultarOpcao)
            {
                case 0:
                    
                    string Login;
                    string senha;
                    Console.WriteLine("Login: ");
                    Login = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Senha: ");
                    senha = Convert.ToString(Console.ReadLine());
                    
                    break;
                
                case 1:
                    string nome;
                    string endereco;
                    string telefone;
                    string dtNascimento;
                    string login1;
                    string senha1;

                    Console.WriteLine("nome: ");
                    nome = Convert.ToString(Console.ReadLine());
                                                                     
                    Console.WriteLine("endereço");
                    endereco = Convert.ToString(Console.ReadLine());
                                                                
                    Console.WriteLine("telefone");
                    telefone = Convert.ToString(Console.ReadLine());
                                                            
                    Console.WriteLine("data de nascimento");
                    dtNascimento = Convert.ToString(Console.ReadLine());
                                                          
                    Console.WriteLine("login");
                    login1 = Convert.ToString(Console.ReadLine());
                                                   
                    Console.WriteLine("senha");                   
                    senha1 = Convert.ToString(Console.ReadLine());
                                                                  
                    break;
            }//fim do switch
                    
                        
                    





                    
        }//
    }
}//