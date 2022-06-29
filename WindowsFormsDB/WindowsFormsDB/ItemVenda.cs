using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsDB
{
    internal class ItemVenda : INotifyPropertyChanged
    {
        private int _id;
        private Venda _venda;
        private Produto _produto;
        private decimal _valor_unit;
        private int _quantidade;
        private decimal _valor_total;

        public int Id { get => _id; set { _id = value; OnPropertyChanged("Id"); } }       
        public decimal Valor_unit { get => _valor_unit; set { _valor_unit = value; OnPropertyChanged("Valor_unit"); } }
        public int Quantidade { get => _quantidade; set { _quantidade = value; OnPropertyChanged("Quantidade"); } }
        public decimal Valor_total { get => _valor_total; set { _valor_total = value; OnPropertyChanged("Valor_total"); } }
        internal Produto Produto { get => _produto; set => _produto = value; }
        internal Venda Venda { get => _venda; set => _venda = value; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
