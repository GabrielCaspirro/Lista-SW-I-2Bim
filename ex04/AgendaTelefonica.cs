class Contato {
    public string? Nome { get; set; }
    public string? Telefone { get; set; }
    public string? Email { get; set; }
}

class AgendaTelefonica {
    private List<Contato> contatos;

    public AgendaTelefonica() {
        contatos = new List<Contato>();
    }

    public void AdicionarContato(string nome, string telefone, string email) {
        contatos.Add(new Contato { Nome = nome, Telefone = telefone, Email = email });
    }

    public void RemoverContato(string nome) {
        for(int i = 0; i < contatos.Count; i++)
        {
            if(nome == contatos[i].Nome){
                contatos.Remove(contatos[i]);
            }
        }
    }

    public string BuscarContato(string nome) {
        for(int i = 0; i < contatos.Count; i++)
        {
            if(nome == contatos[i].Nome){
                return "Telefone: " + contatos[i].Telefone;
            }
        }
        return "Telefone não encontrado";
    }
}