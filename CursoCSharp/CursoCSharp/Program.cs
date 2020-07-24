using CursoCSharp;
using CursoCSharp.Fundamentos;
using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisConstantes.Executar},
                
            });

            central.SelecionarEExecutar();
        }
    }
