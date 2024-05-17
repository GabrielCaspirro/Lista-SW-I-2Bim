using System;
using System.Collections.Generic;

class Tarefa {
    public string? Descricao { get; set; }
    public DateTime DataVencimento { get; set; }
}

class GerenciadorDeTarefas {
    public List<Tarefa> tarefas = new List<Tarefa>();
    public void AdicionarTarefa(string descricao, DateTime dataVencimento) {
        tarefas.Add(new Tarefa { Descricao = descricao, DataVencimento = dataVencimento });
    }

    public void RemoverTarefa(string descricao) {
        for(int i = 0; i < tarefas.Count; i++)
        {
            if(descricao == tarefas[i].Descricao)
            {
                tarefas.Remove(tarefas[i]);
            }
        }
    }

    public void Listar()
    {
        foreach(var tarefa in tarefas)
        {
            Console.WriteLine($"Tarefa: {tarefa.Descricao}, Data de vencimento: {tarefa.DataVencimento.ToShortDateString()}");
        }
    }

    public string TarefaParaHoje(string desc) {
        for(int i = 0; i < tarefas.Count; i++)
        {
            if(desc == tarefas[i].Descricao)
            {
                if(tarefas[i].DataVencimento.Date == DateTime.Today.Date){
                    return "A tarefa é para hoje!";
                }
                else{
                    return "A tarefa não é para hoje!";
                }
            }
        }
        return "Tarefa não encontrada";
    }
}