using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
