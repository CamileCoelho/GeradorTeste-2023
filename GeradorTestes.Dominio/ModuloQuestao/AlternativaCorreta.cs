using System;

namespace GeradorTestes.Dominio.ModuloQuestao
{
    public class AlternativaCorreta
    {
        public AlternativaCorreta(int id, char letra)
        {
            this.id = id;
            this.letra = letra;
        }

        public int id;
        public char letra;

        public override string ToString()
        {
            return string.Format("Letra: {0} N�mero: {1}", id, letra);
        }
    }
}