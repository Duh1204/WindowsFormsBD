using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsDB
{
    internal class Venda : INotifyPropertyChanged
    {
        private int _id;
        private Cliente _cliente_venda;
        private decimal _valor_total;

        public int Id { get => _id; set => _id = value; }        
        public decimal Valor_total { get => _valor_total; set => _valor_total = value; }        
        internal Cliente Cliente_venda { get => _cliente_venda; set => _cliente_venda = value; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
