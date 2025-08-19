using GalaSoft.MvvmLight.Command;
using OakStock.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace OakStock.ViewModels
{
    public class CadastroProdutoViewModel : INotifyPropertyChanged
    {
        public Produto Produto { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand SalvarCommand { get; set; }

        public CadastroProdutoViewModel()
        {
            Produto = new Produto();
            SalvarCommand = new RelayCommand(SalvarProduto);
        }

        private void SalvarProduto()
        {
            // Lógica para salvar produto no banco
        }
    }

}
