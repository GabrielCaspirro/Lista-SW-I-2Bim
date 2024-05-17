using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
        AgendaTelefonica agenda = new AgendaTelefonica();

        agenda.AdicionarContato("Joao", "123456789", "joao@exemplo.com");
        agenda.AdicionarContato("Maria", "987654321", "maria@exemplo.com");

        Console.WriteLine(agenda.BuscarContato("Joao"));
        Console.WriteLine(agenda.BuscarContato("Maria"));

        agenda.RemoverContato("Joao");

        Console.WriteLine(agenda.BuscarContato("Maria"));
        Console.WriteLine(agenda.BuscarContato("Joao"));
    }
}
