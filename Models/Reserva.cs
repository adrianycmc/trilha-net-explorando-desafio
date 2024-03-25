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

            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *OK*

            if (hospedes.Count >= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *OK*
                throw new Exception("Olá! Infelizmente esta suíte possui limitação para no máximo 3 hóspedes.");
            }

        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *OK*
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *OK*
            decimal valorDaDiaria = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *OK*
            if (DiasReservados >= 10)
            {
                return valorDaDiaria * 0.90M; 
            }
            else 
            {  
                 return valorDaDiaria;
            }     
        }
    }
}