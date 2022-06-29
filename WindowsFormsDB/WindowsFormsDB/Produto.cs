using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsDB
{
    internal class Produto : INotifyPropertyChanged
    {
        private int _id;
        private int _cod_ean;
        private string _nome;
        private decimal _preco;
        private int _quantidade;

        public int Id { get => _id; set { _id = value; OnPropertyChanged(nameof(Id)); } }
        public int Cod_ean { get => _cod_ean; set { _cod_ean = value; OnPropertyChanged(nameof(Cod_ean)); } }
        public string Nome { get => _nome; set { _nome = value; OnPropertyChanged(nameof(Nome)); } }
        public decimal Preco { get => _preco; set { _preco = value; OnPropertyChanged(nameof(Preco)); } }
        public int Quantidade { get => _quantidade; set { _quantidade = value; OnPropertyChanged(nameof(Quantidade)); } }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
