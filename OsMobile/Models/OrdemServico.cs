using System;
using System.ComponentModel;

namespace OsMobile.Models
{
    public class OrdemServico : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public int Id { get; set; }
        public string CodigoOS { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string numeroCelular { get; set; }
        public string Status { get; set; }
        public string StatusColor { get; set; }
       
    }
}
