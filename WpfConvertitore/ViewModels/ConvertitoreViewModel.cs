using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

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

        private string _monetaDa;

        public string MonetaDa
        {
            get { return _monetaDa; }
            set { _monetaDa = value; PropChanged("_monetaDa"); }
        }

        private string _monetaA;
        public string MonetaA
        {
            get { return _monetaA; }
            set { _monetaA = value; PropChanged("_monetaA"); }
        }

        private readonly Dictionary<string, double> taxasDeCambio = new Dictionary<string, double>
        {
            { "Real", 1.0 },
            { "Euro", 4.56 },
            { "Dólar", 3.25 }
        };

        public void ConvertireMoneta()
        {
            if (taxasDeCambio.ContainsKey(MonetaDa) && taxasDeCambio.ContainsKey(MonetaA))
            {
                double taxaDeCambioDe = taxasDeCambio[MonetaDa];
                double taxaDeCambioPara = taxasDeCambio[MonetaA];

                Risultato = ValueInput * (taxaDeCambioPara / taxaDeCambioDe);
            }
            else
            {
                Risultato = ValueInput; // Se não houver taxa de câmbio, manter o valor original
            }
        }

        public ConvertitoreViewModel()
        {
            //Monete = new ObservableCollection<string>() { "DML", "ITL", "FRF" };

            //MonetaSelezionata = Monete.FirstOrDefault();
        }
    }
}
