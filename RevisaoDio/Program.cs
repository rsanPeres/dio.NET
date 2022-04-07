using System;

namespace RevisaoDio{    
    class Program{
        static void Main(string[] args)
        {
            StudentsManager stds = new StudentsManager();
            string opUser = showMenu();
            while (opUser.ToUpper() != "X")
            {
                switch (opUser)
                {
                    case "1":
                        
                        Aluno alCat = new Aluno();
                        Console.WriteLine("Informe o nome do aluno: ");
                        if((alCat.Name = Console.ReadLine())== null){
                            throw new IOException("Necessário digitar um nome!!");
                        }
                        Console.WriteLine("Informe a Matricula: ");
                        if(decimal.TryParse(Console.ReadLine(), out decimal mat)){
                            alCat.Matricula = mat;
                        }
                        else{
                            throw new ArgumentException("Valor da nota deve ser decimal");
                        }
                        Console.WriteLine("Informe a Nota: ");
                        var intn = Console.ReadLine();
                        float x;
                        while(!float.TryParse(intn, out x)){
                            Console.WriteLine("Digite uma nota valida..");
                            intn = Console.ReadLine();
                        }
                        alCat.Nota = x;
                        
                        stds.registerStudents(alCat);
            
                        break;
                    
                    case "2":
                        //TODO
                        stds.dumpStudents();
                        break;
                    case "3":
                        //TODO
                        double m = stds.averageStudents();
                        Conceito con;
                        if(m <= 3){
                            con = Conceito.E;
                        }else if(m > 2 && m <= 5){
                            con = Conceito.C;
                        }else if(m > 4 && m <= 7){
                            con = Conceito.B;
                        }else
                            con = Conceito.A;

                        
                        string mform = string.Format("{0:0.00}", m);//TODO verificar formatação
                        Console.WriteLine($@"Conceito {con}
                        A média de notas obtidas foi: {mform}");
                        Console.WriteLine();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opUser = showMenu();
            }

        }

        private static string showMenu()
        {
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Inserir novo Aluno: ");
            Console.WriteLine("2 - Listar alunos: ");
            Console.WriteLine("3 - Calcular média geral: ");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opUser = Console.ReadLine();
            Console.WriteLine();
            return opUser;
        }
    }
}
// parametros out permitem retorno de multiplos valores - violação do princípio de responsabilidade 