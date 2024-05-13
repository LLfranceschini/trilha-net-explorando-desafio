namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            int qtdHospedes = hospedes.Count;
            int capacidade = Suite.Capacidade;

            if (capacidade >= qtdHospedes)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A capacidade de hóspedes não pode exceder a capacidade prevista da suíte");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int qtdHospedes = Hospedes.Count;
            return qtdHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                decimal valorDesconto = valor * 0.10M;
                valor = valor - valorDesconto;
            }

            return valor;
        }
    }
}