using HospedagemHotel.Models;

Pessoa p1 = new Pessoa(nome: "Giordanni", sobrenome: "Formiga");
Pessoa p2 = new Pessoa(nome: "Emily", sobrenome: "Pereira");
Pessoa p3 = new Pessoa(nome: "João", sobrenome: "Silva");
Pessoa p4 = new Pessoa(nome: "Maria", sobrenome: "Santos");

List<Pessoa> hospedes = new List<Pessoa>(){p1, p2, p4};

// Cria a suíte
Suite s1 = new Suite(tipoSuite: "Presidencial", capacidade: 4, valorDiaria: 1000);
Suite s2 = new Suite(tipoSuite: "Luxo", capacidade: 3, valorDiaria: 500);
Suite s3 = new Suite(tipoSuite: "Simples", capacidade: 1, valorDiaria: 200);


try{
    // Cria uma nova reserva, passando a suíte e os hóspedes
    Reserva reserva = new Reserva(diasReservados: 15);
    reserva.CadastrarSuite(s1);
    reserva.AdicionarHospede(hospedes);

    // Exibe a quantidade de hóspedes e o valor da diária
    Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
    Console.WriteLine($"Valor total da diária: {reserva.CalcularValorTotal()}");
    Console.WriteLine("Hóspedes: " + string.Join(", ", reserva.ObterHospedes().Select(h => h.Nome)));
}catch(Exception e){
    Console.WriteLine(e.Message);
}





