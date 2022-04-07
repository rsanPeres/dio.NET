using System;
using System.Collections;
namespace RevisaoDio
{
    public class StudentsManager
    {
        
        private int qtdAls{ get; set; }
        List<Aluno> als = new List<Aluno>();
        
        public StudentsManager(){
            
        }
        public void registerStudents(Aluno al){
            this.als.Add(al);
            this.qtdAls += 1;   
        }

        public Aluno searchStudents(decimal matricula){
            Aluno alMatch = null;
            foreach(var aln in this.als){
                if(matricula.Equals(aln.Matricula)){
                    alMatch = aln;
                    break;
                }
            }
            return alMatch;
        }

        public void dumpStudents(){
            int count = 1;
            Console.WriteLine("Alunos registrados : " + this.qtdAls);
            Console.WriteLine();
            foreach(var aln in this.als){
                Console.WriteLine();
                Console.WriteLine("Aluno " + count + " " + aln.Name);
                Console.WriteLine(aln.Matricula);
                Console.WriteLine();
                Console.WriteLine(aln.Nota);
                Console.WriteLine();
                count += 1;
            }
        }

        public double averageStudents(){
            float average = 0;
            foreach(var aln in this.als){
                average += aln.Nota;
            }

            return (average/this.qtdAls);
        }
    }

}