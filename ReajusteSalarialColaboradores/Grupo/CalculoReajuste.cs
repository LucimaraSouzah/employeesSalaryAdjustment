namespace ReajusteSalarialColaboradores.Grupo
{
    public class CalculoReajuste: IReajuste
    {
        public double ReajusteSalarial(double salario, double porcentagemReajuste)
        {
            return  salario + (salario * (porcentagemReajuste / 100));
        }
    }
}
