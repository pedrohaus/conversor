using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfConvertitore.ViewModels
{
    internal class ConvertitoreViewModel : BaseViewModel
    {
        public ObservableCollection<string> Monete { get; set; }    
        public String MonetaSelezionata { get; set; }

        private double _risultato;

        public double Risultato
        {
            get { return _risultato; }
            set { _risultato = value; PropChanged("Risultato"); }
        }

        private double _valueInput;

        public double ValueInput
        {
            get { return _valueInput; }
            set { _valueInput = value; PropChanged("ValueInput"); }
        }

        private double _valoreSelezionatoDa;

        public double ValoreSelezionatoDa
        {
            get { return _valoreSelezionatoDa; }
            set { _valoreSelezionatoDa = value; PropChanged("ValoreSelezionatoDa"); }
        }

        private double _valoreSelezionatoA;
        public double ValoreSelezionatoA
        {
            get { return _valoreSelezionatoA; }
            set { _valoreSelezionatoA = value; PropChanged("ValoreSelezionatoA"); }
        }




        public ConvertitoreViewModel()
        {
            Monete = new ObservableCollection<string>() { "DML", "ITL", "FRF"};

            //MonetaSelezionata = Monete.FirstOrDefault();
        }

        public void ConvertireMoneta(object parameter)
        {
            if (double.TryParse(ValueInput.ToString(), out double valor))
            {
                string moedaDe = ValoreSelezionatoDa;
                string moedaPara = ValoreSelezionataA;

                if (!string.IsNullOrEmpty(moedaDe) && !string.IsNullOrEmpty(moedaPara))
                {
                    try
                    {
                        // Chamar o serviço WCF ou qualquer outra lógica necessária
                        double resultado = // Lógica de conversão;

                        // Atualizar o resultado na ViewModel
                        Risultato = $"Valore convertito: {Risultato}";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Selezionare le valute di origine e destinazione.");
                }
            }
            else
            {
                MessageBox.Show("Inserire un valore valido.");
            }
        }
    }

    }
}
