namespace RevisaoDio
{
    public class Aluno
    {
        private float nota;
        public string Name { get; set; }//criado usando prop+tab
        public decimal Matricula { get; set; }

        public float Nota { get{
            return this.nota;
        } 
        set{
            this.nota = value;
        } }
    }
}

// Atribudos x Propriedades
//Atributos interagem com o compilador para definir comportamentos 
//Propriedades são como os atributos em java