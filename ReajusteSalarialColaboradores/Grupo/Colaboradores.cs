namespace ReajusteSalarialColaboradores.Grupo
{
    public class Colaboradores
    {
        CalculoReajuste calculo = new CalculoReajuste();
        private string anoContratacao;
        private string nome;
        private string cargo;
        private string cadastrarFuncionario;
        private double salario;
        private double porcentagemReajuste;
        private bool elegivelReajuste;

        public string Nome { get => nome; set => nome = value; }
        public string Cargo { get => cargo; set => cargo = value; }

        public string AnoContratacao
        {
            get { return anoContratacao; }
            set
            {
                anoContratacao = value;
                {
                    if (value.Length == 4 && value != "2022" && value != "2021")
                    {
                        Console.WriteLine("Está elegível para o reajuste salarial!");
                        elegivelReajuste = true;
                    }
                    else if (value.Length == 4)
                    {
                        Console.WriteLine("Não está elegível para o reajuste salarial!");
                        elegivelReajuste = false;
                    } else
                    {
                        Console.WriteLine("Por favor, digite o ano de contratação com 4 dígitos.");
                        Console.WriteLine("Ano contratação: ");
                        AnoContratacao = Convert.ToString(Console.ReadLine());
                    }
                }
               
            }
        }
        public double PorcentagemReajuste { get => porcentagemReajuste; set => porcentagemReajuste = value; }
        public double Salario { get { return salario;}
            set { 
            salario= value;
                if(elegivelReajuste == true && value > 7000)
                {
                    salario = salario + (salario * 0.10);
                    Console.WriteLine("O salário com o reajuste de 10% será: " + salario);
                } else if (elegivelReajuste == true && value <= 7000)
                {
                    Console.WriteLine("Qual será a % do reajuste salarial?");
                    double porcentagemReajuste = Convert.ToDouble(Console.ReadLine());
                    salario = calculo.ReajusteSalarial(salario, porcentagemReajuste);
                    Console.WriteLine("O salário com " + porcentagemReajuste + "% de reajuste salarial será: " + salario);
                }
            }
        }
        public string CadastrarFuncionario { get => cadastrarFuncionario; set => cadastrarFuncionario = value; }

        public void mensagemDadosColaborador()
        {
            do
            {
                Console.WriteLine("Nome: ");
                Nome = Console.ReadLine();
                Console.WriteLine("Cargo: ");
                Cargo = Console.ReadLine();
                Console.WriteLine("Ano contratação: ");
                AnoContratacao = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Salário: ");
                Salario = Double.Parse(Console.ReadLine());
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Deseja cadastrar outro funcionário? ");
                cadastrarFuncionario = Console.ReadLine().ToLower();
            } while (cadastrarFuncionario == "sim");
        }

    }
}










