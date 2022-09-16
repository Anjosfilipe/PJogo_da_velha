using System;
using System.Threading.Tasks;
using System.Text;

namespace PJogo_da_Velha
{
    internal class Program
    {
        static void gameoverX()
        {
            Console.WriteLine(@"

                                                                                                    ('-.      _ .-') _                 _  .-')         ) (`-.            
                                                                          ( OO ).-. ( (  OO) )               ( \( -O )         ( OO ).          
                                         ,--.  .-'),-----.   ,----.       / . --. /  \     .'_   .-'),-----.  ,------.        (_/.  \_)-.       
                                     .-')| ,| ( OO'  .-.  ' '  .-./-')    | \-.  \   ,`'--..._) ( OO'  .-.  ' |   /`. '        \  `.'  /        
                                    ( OO |(_| /   |  | |  | |  |_( O- ) .-'-'  |  |  |  |  \  ' /   |  | |  | |  /  | |         \     /\        
                                    | `-'|  | \_) |  |\|  | |  | .--, \  \| |_.'  |  |  |   ' | \_) |  |\|  | |  |_.' |          \   \ |        
                                    ,--. |  |   \ |  | |  |(|  | '. (_/   |  .-.  |  |  |   / :   \ |  | |  | |  .  '.'         .'    \_)       
                                    |  '-'  /    `'  '-'  ' |  '--'  |    |  | |  |  |  '--'  /    `'  '-'  ' |  |\  \         /  .'.  \        
                                     `-----'       `-----'   `------'     `--' `--'  `-------'       `-----'  `--' '--'       '--'   '--'         
                                                                                                                                                                                                                               ");
        
            Console.WriteLine(@"                                                                                                                                           
                                                                                                                                         
VVVVVVVV           VVVVVVVVEEEEEEEEEEEEEEEEEEEEEENNNNNNNN        NNNNNNNN        CCCCCCCCCCCCCEEEEEEEEEEEEEEEEEEEEEEUUUUUUUU     UUUUUUUU
V::::::V           V::::::VE::::::::::::::::::::EN:::::::N       N::::::N     CCC::::::::::::CE::::::::::::::::::::EU::::::U     U::::::U
V::::::V           V::::::VE::::::::::::::::::::EN::::::::N      N::::::N   CC:::::::::::::::CE::::::::::::::::::::EU::::::U     U::::::U
V::::::V           V::::::VEE::::::EEEEEEEEE::::EN:::::::::N     N::::::N  C:::::CCCCCCCC::::CEE::::::EEEEEEEEE::::EUU:::::U     U:::::UU
 V:::::V           V:::::V   E:::::E       EEEEEEN::::::::::N    N::::::N C:::::C       CCCCCC  E:::::E       EEEEEE U:::::U     U:::::U 
  V:::::V         V:::::V    E:::::E             N:::::::::::N   N::::::NC:::::C                E:::::E              U:::::D     D:::::U 
   V:::::V       V:::::V     E::::::EEEEEEEEEE   N:::::::N::::N  N::::::NC:::::C                E::::::EEEEEEEEEE    U:::::D     D:::::U 
    V:::::V     V:::::V      E:::::::::::::::E   N::::::N N::::N N::::::NC:::::C                E:::::::::::::::E    U:::::D     D:::::U 
     V:::::V   V:::::V       E:::::::::::::::E   N::::::N  N::::N:::::::NC:::::C                E:::::::::::::::E    U:::::D     D:::::U 
      V:::::V V:::::V        E::::::EEEEEEEEEE   N::::::N   N:::::::::::NC:::::C                E::::::EEEEEEEEEE    U:::::D     D:::::U 
       V:::::V:::::V         E:::::E             N::::::N    N::::::::::NC:::::C                E:::::E              U:::::D     D:::::U 
        V:::::::::V          E:::::E       EEEEEEN::::::N     N:::::::::N C:::::C       CCCCCC  E:::::E       EEEEEE U::::::U   U::::::U 
         V:::::::V         EE::::::EEEEEEEE:::::EN::::::N      N::::::::N  C:::::CCCCCCCC::::CEE::::::EEEEEEEE:::::E U:::::::UUU:::::::U 
          V:::::V          E::::::::::::::::::::EN::::::N       N:::::::N   CC:::::::::::::::CE::::::::::::::::::::E  UU:::::::::::::UU  
           V:::V           E::::::::::::::::::::EN::::::N        N::::::N     CCC::::::::::::CE::::::::::::::::::::E    UU:::::::::UU    
            VVV            EEEEEEEEEEEEEEEEEEEEEENNNNNNNN         NNNNNNN        CCCCCCCCCCCCCEEEEEEEEEEEEEEEEEEEEEE      UUUUUUUUU      
                                                                                                                                                                                         
                                                                                                                                                                                         
                                                                                                                                                                                         
                                                                                                                                                                                         
                                                                                                                                                                                           ");
            
        }
        static void gameoverO()
        {
            Console.WriteLine(@"                                                                                                                                                                                   
                                                                                                                                                                                  
                                                                               ('-.      _ .-') _                 _  .-')                      
                                                                      ( OO ).-. ( (  OO) )               ( \( -O )                     
                                     ,--.  .-'),-----.   ,----.       / . --. /  \     .'_   .-'),-----.  ,------.         .-'),-----. 
                                 .-')| ,| ( OO'  .-.  ' '  .-./-')    | \-.  \   ,`'--..._) ( OO'  .-.  ' |   /`. '       ( OO'  .-.  '
                                ( OO |(_| /   |  | |  | |  |_( O- ) .-'-'  |  |  |  |  \  ' /   |  | |  | |  /  | |       /   |  | |  |
                                | `-'|  | \_) |  |\|  | |  | .--, \  \| |_.'  |  |  |   ' | \_) |  |\|  | |  |_.' |       \_) |  |\|  |
                                ,--. |  |   \ |  | |  |(|  | '. (_/   |  .-.  |  |  |   / :   \ |  | |  | |  .  '.'         \ |  | |  |
                                |  '-'  /    `'  '-'  ' |  '--'  |    |  | |  |  |  '--'  /    `'  '-'  ' |  |\  \           `'  '-'  '
                                 `-----'       `-----'   `------'     `--' `--'  `-------'       `-----'  `--' '--'            `-----'               
                                                                                                                                                                                  
                                                                                                                                                                                  
                                                                                                                                                                                  
                                                                                                                                                                                  
                                                                                                                                                                                  
                                                                                                                                                                                   ");
            
            Console.WriteLine(@"                                                                                                                                           
                                                                                                                                         
VVVVVVVV           VVVVVVVVEEEEEEEEEEEEEEEEEEEEEENNNNNNNN        NNNNNNNN        CCCCCCCCCCCCCEEEEEEEEEEEEEEEEEEEEEEUUUUUUUU     UUUUUUUU
V::::::V           V::::::VE::::::::::::::::::::EN:::::::N       N::::::N     CCC::::::::::::CE::::::::::::::::::::EU::::::U     U::::::U
V::::::V           V::::::VE::::::::::::::::::::EN::::::::N      N::::::N   CC:::::::::::::::CE::::::::::::::::::::EU::::::U     U::::::U
V::::::V           V::::::VEE::::::EEEEEEEEE::::EN:::::::::N     N::::::N  C:::::CCCCCCCC::::CEE::::::EEEEEEEEE::::EUU:::::U     U:::::UU
 V:::::V           V:::::V   E:::::E       EEEEEEN::::::::::N    N::::::N C:::::C       CCCCCC  E:::::E       EEEEEE U:::::U     U:::::U 
  V:::::V         V:::::V    E:::::E             N:::::::::::N   N::::::NC:::::C                E:::::E              U:::::D     D:::::U 
   V:::::V       V:::::V     E::::::EEEEEEEEEE   N:::::::N::::N  N::::::NC:::::C                E::::::EEEEEEEEEE    U:::::D     D:::::U 
    V:::::V     V:::::V      E:::::::::::::::E   N::::::N N::::N N::::::NC:::::C                E:::::::::::::::E    U:::::D     D:::::U 
     V:::::V   V:::::V       E:::::::::::::::E   N::::::N  N::::N:::::::NC:::::C                E:::::::::::::::E    U:::::D     D:::::U 
      V:::::V V:::::V        E::::::EEEEEEEEEE   N::::::N   N:::::::::::NC:::::C                E::::::EEEEEEEEEE    U:::::D     D:::::U 
       V:::::V:::::V         E:::::E             N::::::N    N::::::::::NC:::::C                E:::::E              U:::::D     D:::::U 
        V:::::::::V          E:::::E       EEEEEEN::::::N     N:::::::::N C:::::C       CCCCCC  E:::::E       EEEEEE U::::::U   U::::::U 
         V:::::::V         EE::::::EEEEEEEE:::::EN::::::N      N::::::::N  C:::::CCCCCCCC::::CEE::::::EEEEEEEE:::::E U:::::::UUU:::::::U 
          V:::::V          E::::::::::::::::::::EN::::::N       N:::::::N   CC:::::::::::::::CE::::::::::::::::::::E  UU:::::::::::::UU  
           V:::V           E::::::::::::::::::::EN::::::N        N::::::N     CCC::::::::::::CE::::::::::::::::::::E    UU:::::::::UU    
            VVV            EEEEEEEEEEEEEEEEEEEEEENNNNNNNN         NNNNNNN        CCCCCCCCCCCCCEEEEEEEEEEEEEEEEEEEEEE      UUUUUUUUU      
                                                                                                                                                                                         
                                                                                                                                                                                         
                                                                                                                                                                                         
                                                                                                                                                                                         
                                                                                                                                                                                           ");
            

        }
        static void tabuleiro(char[,] pos_tabuleiro, int cont_jogadas)
        {
            Console.Clear();         
            Console.WriteLine("\n\n\n\n --------------------  JOGO DA VELHA   ----------------------- \t          -------------------  EXEMPLO DE COORDENADAS  ----------------------");
            Console.WriteLine("\n\n\t\t     {0}  ||  {1}  ||  {2} \t\t\t\t\t\t\t      1/1   ||  1/2   || 1/3  ", pos_tabuleiro[0, 0], pos_tabuleiro[0, 1], pos_tabuleiro[0, 2]);
            Console.WriteLine("\t\t    _________________ \t\t\t\t\t\t\t  ______________________________");
            Console.WriteLine("\n\t\t     {0}  ||  {1}  ||  {2} \t\t\t\t\t\t\t      2/1   ||  2/2   || 2/3 ", pos_tabuleiro[1, 0], pos_tabuleiro[1, 1], pos_tabuleiro[1, 2]);
            Console.WriteLine("\t\t    _________________ \t\t\t\t\t\t\t  ______________________________ ");
            Console.WriteLine("\n\t\t     {0}  ||  {1}  ||  {2} \t\t\t\t\t\t\t      3/1   ||  3/2  ||  3/3", pos_tabuleiro[2, 0], pos_tabuleiro[2, 1], pos_tabuleiro[2, 2]);

            Console.WriteLine("\n\nNumero de jogadas atuais: " + cont_jogadas);
        }
        static void limpa_tabuleiro(char[,] pos_tabuleiro, int cont_jogadas, int jogada)
        {
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    pos_tabuleiro[i, j] = ' ';
                }
            }

        }
        static void menu_iniciar()
        {


             Console.WriteLine("\n\n\n\t\t\t" + @"


                                                 )                )      (                                  (         )            
                                    ( /(    (        ( /(      )\ )      (                        )\ )   ( /(     (      
                               (    )\())   )\ )     )\())    (()/(      )\        (   (    (    (()/(   )\())    )\     
                               )\  ((_)\   (()/(    ((_)\      /(_))  ((((_)(      )\  )\   )\    /(_)) ((_)\  ((((_)(   
                              ((_)   ((_)   /(_))_    ((_)    (_))_    )\ _ )\    ((_)((_) ((_)  (_))    _((_)  )\ _ )\  
                             _ | |  / _ \  (_)) __|  / _ \     |   \   (_)_\(_)   \ \ / /  | __| | |    | || |  (_)_\(_) 
                            | || | | (_) |   | (_ | | (_) |    | |) |   / _ \      \ V /   | _|  | |__  | __ |   / _ \   
                             \__/   \___/     \___|  \___/     |___/   /_/ \_\      \_/    |___| |____| |_||_|  /_/ \_\"); 

            Console.WriteLine("\n\n\t\t        Regras do jogo: ");
            Console.WriteLine("\n\t\t         ° Tire par ou impar para saber quem inicia como o jogador 'O'.");
            Console.Write("\n                         ° Este jogo da Velha funciona por cordenadas cartesianas. Abaixo  temos o exemplo de coordenadas || ");
            Console.WriteLine("\n\n\t\t         ° Para vencer a partida basta um do jogadores 'O' ou 'X', preencher uma coluna, linha ou diagonal completas!");
            Console.WriteLine("\n\t\t         ° Caso isso não aconteça o jogo da VELHA! então é so reiniciar o jogo ou não. Fica a seu critério aceitar empatar kkkk");

            Console.WriteLine("\n\n\n\n\t\t        -----------------------------------  EXEMPLO DE COORDENADAS  --------------------------------------");
            Console.WriteLine("\n\n\t\t\t\t\t\t\t      1/1   ||  1/2   || 1/3  ");
            Console.WriteLine("\t\t\t\t\t\t\t  ______________________________ ");
            Console.WriteLine("\n\t\t\t\t\t\t\t      2/1   ||  2/2   || 2/3  ");
            Console.WriteLine("\t\t\t\t\t\t\t  ______________________________ ");
            Console.WriteLine("\n\t\t\t\t\t\t\t       3/1  ||  3/2  ||  3/3 ");

            Console.WriteLine("\n\n\n\t\t\t\t\t\t\t  ______________________________ ");
            Console.WriteLine("\n\t\t\t\t\t\t\t  |  tecle ENTER para JOGAR!!!  |");
            Console.WriteLine("\t\t\t\t\t\t\t  ______________________________ ");
            Console.ReadKey();

        }
        static void Main(string[] args)
        {
            char[,] pos_tabuleiro = new char[3, 3];
            char resposta;
            int cont_jogadas = 0, linhas, colunas, jogada = 1;

            menu_iniciar();

            do
            {
                limpa_tabuleiro(pos_tabuleiro, jogada, cont_jogadas);

                cont_jogadas = 0;
                jogada = 1;

                do
                {
                    tabuleiro(pos_tabuleiro, cont_jogadas);


                    if (jogada % 2 == 0)
                    {
                        Console.WriteLine("\n\nJogador X\n");
                    }
                    else
                    {
                        Console.WriteLine("\n\nJogador O\n");
                    }

                    Console.Write("Selecione a linha:  ");
                    linhas = int.Parse(Console.ReadLine());

                    Console.Write("Selecione a coluna:  ");
                    colunas = int.Parse(Console.ReadLine());


                    if (linhas < 1 || linhas > 3 || colunas < 1 || colunas > 3)
                    {
                        linhas = 0;
                        colunas = 0;
                        Console.WriteLine("Coordenadas inexistentes, informe novamente");

                    }
                    else if (pos_tabuleiro[linhas - 1, colunas - 1] != ' ')
                    {
                        linhas = 0;
                        colunas = 0;
                        Console.WriteLine("Coordenadas já preenchidas, informe novamente");
                    }
                    else
                    {
                        if (jogada % 2 == 0)
                        {
                            pos_tabuleiro[linhas - 1, colunas - 1] = 'X';
                            Console.Beep();
                        }
                        else
                        {
                            pos_tabuleiro[linhas - 1, colunas - 1] = 'O';
                            Console.Beep();
                        }

                        jogada++;
                        cont_jogadas++;
                    }

                    if (pos_tabuleiro[0, 0] == 'X' && pos_tabuleiro[0, 1] == 'X' && pos_tabuleiro[0, 2] == 'X')
                    {
                        tabuleiro(pos_tabuleiro, cont_jogadas);
                        Console.Clear();
                        gameoverX();
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        cont_jogadas = 11;
                        Console.WriteLine("\n\n\n\t   tecle ENTER para CONTINUAR!!!");
                        Console.ReadKey();
                    }

                    if (pos_tabuleiro[1, 0] == 'X' && pos_tabuleiro[1, 1] == 'X' && pos_tabuleiro[1, 2] == 'X')
                    {
                        tabuleiro(pos_tabuleiro, cont_jogadas);
                        Console.Clear();
                        gameoverX();
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        cont_jogadas = 11;
                        Console.WriteLine("\n\n\n\t   tecle ENTER para CONTINUAR!!!");
                        Console.ReadKey();
                    }

                    if (pos_tabuleiro[2, 0] == 'X' && pos_tabuleiro[2, 1] == 'X' && pos_tabuleiro[2, 2] == 'X')
                    {
                        tabuleiro(pos_tabuleiro, cont_jogadas);
                        Console.Clear();
                        gameoverX();
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        cont_jogadas = 11;
                        Console.WriteLine("\n\n\n\t   tecle ENTER para CONTINUAR!!!");
                        Console.ReadKey();
                    }

                    if (pos_tabuleiro[0, 0] == 'X' && pos_tabuleiro[1, 0] == 'X' && pos_tabuleiro[2, 0] == 'X')
                    {
                        tabuleiro(pos_tabuleiro, cont_jogadas);
                        Console.Clear();
                        gameoverX();
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        cont_jogadas = 11;
                        Console.WriteLine("\n\n\n\t   tecle ENTER para CONTINUAR!!!");
                        Console.ReadKey();
                    }

                    if (pos_tabuleiro[0, 1] == 'X' && pos_tabuleiro[1, 1] == 'X' && pos_tabuleiro[2, 1] == 'X')
                    {
                        tabuleiro(pos_tabuleiro, cont_jogadas);
                        Console.Clear();
                        gameoverX();
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        cont_jogadas = 11;
                        Console.WriteLine("\n\n\n\t   tecle ENTER para CONTINUAR!!!");
                        Console.ReadKey();
                    }

                    if (pos_tabuleiro[0, 2] == 'X' && pos_tabuleiro[1, 2] == 'X' && pos_tabuleiro[2, 2] == 'X')
                    {
                        tabuleiro(pos_tabuleiro, cont_jogadas);
                        Console.Clear();
                        gameoverX();
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        cont_jogadas = 11;
                        Console.WriteLine("\n\n\n\t   tecle ENTER para CONTINUAR!!!");
                        Console.ReadKey();
                    }

                    if (pos_tabuleiro[0, 2] == 'X' && pos_tabuleiro[1, 1] == 'X' && pos_tabuleiro[2, 0] == 'X')
                    {
                        tabuleiro(pos_tabuleiro, cont_jogadas);
                        Console.Clear();
                        gameoverX();
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        cont_jogadas = 11;
                        Console.WriteLine("\n\n\n\t   tecle ENTER para CONTINUAR!!!");
                        Console.ReadKey();
                    }

                    if (pos_tabuleiro[0, 0] == 'X' && pos_tabuleiro[1, 1] == 'X' && pos_tabuleiro[2, 2] == 'X')
                    {
                        tabuleiro(pos_tabuleiro, cont_jogadas);
                        Console.Clear();
                        gameoverX();
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        cont_jogadas = 11;
                        Console.WriteLine("\n\n\n\t   tecle ENTER para CONTINUAR!!!");
                        Console.ReadKey();
                    }
                    // -----------------------------------------------------------------------------------------// 

                    if (pos_tabuleiro[0, 0] == 'O' && pos_tabuleiro[0, 1] == 'O' && pos_tabuleiro[0, 2] == 'O')
                    {
                        tabuleiro(pos_tabuleiro, cont_jogadas);
                        Console.Clear();
                        gameoverO();
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        cont_jogadas = 11;
                        Console.WriteLine("\n\n\n\t   tecle ENTER para CONTINUAR!!!");
                        Console.ReadKey();
                    }

                    if (pos_tabuleiro[1, 0] == 'O' && pos_tabuleiro[1, 1] == 'O' && pos_tabuleiro[1, 2] == 'O')
                    {
                        tabuleiro(pos_tabuleiro, cont_jogadas);
                        Console.Clear();
                        gameoverO();
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        cont_jogadas = 11;
                        Console.WriteLine("\n\n\n\t   tecle ENTER para CONTINUAR!!!");
                        Console.ReadKey();
                    }

                    if (pos_tabuleiro[2, 0] == 'O' && pos_tabuleiro[2, 1] == 'O' && pos_tabuleiro[2, 2] == 'O')
                    {
                        tabuleiro(pos_tabuleiro, cont_jogadas);
                        Console.Clear();
                        gameoverO();
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        cont_jogadas = 11;
                        Console.WriteLine("\n\n\n\t   tecle ENTER para CONTINUAR!!!");
                        Console.ReadKey();
                    }

                    if (pos_tabuleiro[0, 0] == 'O' && pos_tabuleiro[1, 0] == 'O' && pos_tabuleiro[2, 0] == 'O')
                    {
                        tabuleiro(pos_tabuleiro, cont_jogadas);
                        Console.Clear();
                        gameoverO();
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        cont_jogadas = 11;
                        Console.WriteLine("\n\n\n\t   tecle ENTER para CONTINUAR!!!");
                        Console.ReadKey();
                    }

                    if (pos_tabuleiro[0, 1] == 'O' && pos_tabuleiro[1, 1] == 'O' && pos_tabuleiro[2, 1] == 'O')
                    {
                        tabuleiro(pos_tabuleiro, cont_jogadas);
                        Console.Clear();
                        gameoverO();
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        cont_jogadas = 11;
                        Console.WriteLine("\n\n\n\t   tecle ENTER para CONTINUAR!!!");
                        Console.ReadKey();
                    }

                    if (pos_tabuleiro[0, 2] == 'O' && pos_tabuleiro[1, 2] == 'O' && pos_tabuleiro[2, 2] == 'O')
                    {
                        tabuleiro(pos_tabuleiro, cont_jogadas);
                        Console.Clear();
                        gameoverO();
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        cont_jogadas = 11;
                        Console.WriteLine("\n\n\n\t   tecle ENTER para CONTINUAR!!!");
                        Console.ReadKey();
                    }

                    if (pos_tabuleiro[0, 2] == 'O' && pos_tabuleiro[1, 1] == 'O' && pos_tabuleiro[2, 0] == 'O')
                    {
                        tabuleiro(pos_tabuleiro, cont_jogadas);
                        Console.Clear();
                        gameoverO();
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        cont_jogadas = 11;
                        Console.WriteLine("\n\n\n\t   tecle ENTER para CONTINUAR!!!");
                        Console.ReadKey();
                    }

                    if (pos_tabuleiro[0, 0] == 'O' && pos_tabuleiro[1, 1] == 'O' && pos_tabuleiro[2, 2] == 'O')
                    {
                        tabuleiro(pos_tabuleiro, cont_jogadas);
                        Console.Clear();
                        gameoverO();
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        cont_jogadas = 11;
                        Console.WriteLine("\n\n\n\t   tecle ENTER para CONTINUAR!!!");
                        Console.ReadKey();
                    }

                } while (cont_jogadas < 9);

                Console.WriteLine("\t\t\t\t\t\t _________________________________");
                Console.WriteLine("\t\t\t\t\t\t |Deseja jogar novamente?: [S -N]|");
                Console.WriteLine("\t\t\t\t\t\t _________________________________");
                resposta = char.ToLower(char.Parse(Console.ReadLine()));
            } while (resposta == 's');

            if(resposta == 's')
            {

            menu_iniciar();
            }
            else
            {
                Console.WriteLine("OBRIGADO POR JOGAR O GAME DO BARATÃO!!!!!! VOLTE LOGO.");
            }

        }
    }
}
