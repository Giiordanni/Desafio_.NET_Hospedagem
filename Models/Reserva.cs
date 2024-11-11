using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospedagemHotel.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public Reserva() { }

        public void AdicionarHospede(List<Pessoa> hospedes)
        {
            if(hospedes.Count > Suite.Capacidade){
                throw new Exception($"Infelizmente temos apenas {Suite.Capacidade} vagas disponíveis.");
            }
            if(hospedes.Count == 0){
                throw new Exception("Não identificamos pessoas para hospedagem.");
            }
            Hospedes = hospedes;
            
        }

        public void CadastrarSuite(Suite suite){
            Suite = suite;
        }

        public int ObterQuantidadeHospedes(){
            if(Suite == null){
                throw new Exception("Não identificamos a sua reserva.");
            }
            return Hospedes.Count;
        }

        public decimal CalcularValorTotal(){
            if (DiasReservados >= 10)
            {
                Console.WriteLine($"Diária: {Suite.ValorDiaria}\nParabéns você ganhou um desconto de 10% por ter reservado a suíte por {DiasReservados} dias.");
                return Suite.ValorDiaria * DiasReservados * 0.9m;
            }
            return Suite.ValorDiaria * DiasReservados;
        }

        public List<Pessoa> ObterHospedes(){
            return Hospedes.GetHashCode() == 0 ? throw new Exception("Não identificamos hóspedes.") : Hospedes;
        }
    }
}