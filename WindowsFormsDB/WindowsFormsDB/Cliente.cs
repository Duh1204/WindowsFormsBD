using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WindowsFormsDB
{
    internal class Cliente : INotifyPropertyChanged
    {
        private int _id;
        private string _nome;
        private int _cpf;

        public int Id { get => _id; set { _id = value; OnPropertyChanged(nameof(Id)); } }
        public string Nome { get => _nome; set { _nome = value; OnPropertyChanged(nameof(Nome)); } }
        public int Cpf { get => _cpf; set { _cpf = value; OnPropertyChanged(nameof(Cpf)); } }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }

    
}
